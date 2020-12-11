using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Logger;
using MovieStore.Repositories.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<MovieRepository> _logger;

        public MovieRepository(DataContext context, ILogger<MovieRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddMovie(Movie movie)
        {
            try {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                _logger.LogInformation(LoggerMessageDisplay.MovieCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieEditNotFound, ex);
            }      
        }

        public void DeleteMovie(int movieID)
        {
            Movie movie = GetMovieById(movieID);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByDateAccending()
        {
            var result = _context.Movies.AsEnumerable().OrderBy(x => x.YearOfRelease);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByDateDescending()
        {
            var result = _context.Movies.AsEnumerable().OrderByDescending(x => x.YearOfRelease);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByGeoLocationCountry(string country)
        {
            var result = _context.Movies.AsEnumerable().Where(x => x.Country == country);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByPriceAccending()
        {
            var result = _context.Movies.AsEnumerable().OrderBy(x => x.Price);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByPriceDescending()
        {
            var result = _context.Movies.AsEnumerable().OrderByDescending(x => x.Price);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByUser(User user)
        {
            var result = _context.Movies.AsEnumerable().Where(x => x.User == user);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByUserId(int userId)
        {
            var result = _context.Movies.AsEnumerable().Where(x => x.UserId == userId);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesForWishlist()
        {
            var result = _context.Movies.AsEnumerable();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesFromToDateByUserId(int userId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movie> GetAllMoviesQueryable()
        {
            var result = _context.Movies.AsQueryable();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _context.Movies.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Movie> GetTopPopularMovies()
        {
            var result = _context.Movies.AsEnumerable().OrderByDescending(x => x.SoldItems).Take(6);
            return result;
        }

        public IEnumerable<Movie> GetTopPopularMoviesByBestSellingDirector(int directorId)
        {
            var result = _context.Movies.AsEnumerable().Where(x => x.DirectorID == directorId);
            return result;
        }
    }
}
