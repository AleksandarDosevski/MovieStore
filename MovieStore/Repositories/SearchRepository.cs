using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        private readonly DataContext _context;

        public SearchRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }

        public Movie GetMovie(int id)
        {
            var result = _context.Movies.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Movie> SearchMovies(List<string> keywords, string title, string director, string category)
        {
            List<Movie> movies = new List<Movie>();

            IQueryable<Movie> moviesQueryableList = Enumerable.Empty<Movie>().AsQueryable();

            if (keywords.Count > 0)
            {
                foreach (string item in keywords)
                {
                    var movie = _context.Movies.ToList().Where(
                                    x => x.Title.Contains(item, StringComparison.OrdinalIgnoreCase) ||
                                    x.CategoryName.Contains(item, StringComparison.OrdinalIgnoreCase) ||
                                    x.DirectorName.Contains(item, StringComparison.OrdinalIgnoreCase)
                                  ).DefaultIfEmpty();

                    if (movie != null)
                    {
                        movies.AddRange(movie);
                    }
                }
            }
            else
            {
                movies = _context.Movies.ToList();
            }

            // check other criterias  
            movies = CheckSearchCriteria(movies, title, director, category).ToList();

            return movies.Distinct().OrderBy(x => x.Id);
        }


        #region Helpers and Private Methods

        private IEnumerable<Movie> CheckSearchCriteria(List<Movie> MovieList, string title, string director, string category)
        {
            List<Movie> moviesCriteria = new List<Movie>();

            if ((title == "undefined" || title == null) && (director == "undefined" || director == null) && (category == "undefined" || category == null) )
            {
                return MovieList;
            }

            // title / director / category
            if (title != "undefined" || title != null && director != "undefined" || director != null && category != "undefined" || category != null)
            {
                moviesCriteria = MovieList.FindAll(x => x.Title == title);
                moviesCriteria = moviesCriteria.FindAll(x => x.DirectorName == director);
                moviesCriteria = moviesCriteria.FindAll(x => x.CategoryName == category);
            }

            // title and director
            if (title != "undefined" || title != null && director != "undefined" || director != null && category == null || category == "undefined")
            {
                moviesCriteria = MovieList.FindAll(x => x.Title == title);
                moviesCriteria = moviesCriteria.FindAll(x => x.DirectorName == director);
            }

            // director and category
            if (director != "undefined" || director != null && category != "undefined" || category != null && title == "undefined" || title == null)
            {
                moviesCriteria = MovieList.FindAll(x => x.DirectorName == director);
                moviesCriteria = moviesCriteria.FindAll(x => x.CategoryName == category);
            }

            // title and category
            if (title != "undefined" || title != null && category == "undefined" || category == null)
            {
                moviesCriteria = MovieList.FindAll(x => x.Title == title);
                moviesCriteria = MovieList.Where(x => x.CategoryName == category).ToList();
            }

            // only title
            if (title != "undefined" || title != null && ((director == "undefined" || director == null) && (category == "undefined" || category == null)))
            {
                moviesCriteria = MovieList.FindAll(x => x.Title == title);
            }

            // only director
            if (director != "undefined" || director != null && ((title == "undefined" || title == null) && (category == "undefined" || category == null)))
            {
                moviesCriteria = MovieList.FindAll(x => x.DirectorName == director);
            }

            // only category
            if (category != "undefined" || category != null && ((director == "undefined" || director == null) && (title == "undefined" || title == null)))
            {
                moviesCriteria = MovieList.Where(x => x.CategoryName == category).ToList();
            }

            return moviesCriteria;
        }

        #endregion
    }
}
