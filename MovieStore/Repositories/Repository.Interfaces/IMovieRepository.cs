using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories.Repository.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieID);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
        IQueryable<Movie> GetAllMoviesQueryable();

       
        IEnumerable<Movie> GetAllMoviesByUser(User user);
        IEnumerable<Movie> GetAllMoviesByUserId(int userId);
        IEnumerable<Movie> GetAllMoviesByDateDescending();
        IEnumerable<Movie> GetAllMoviesByDateAccending();
        IEnumerable<Movie> GetAllMoviesFromToDateByUserId(int userId, DateTime from, DateTime to);
        IEnumerable<Movie> GetAllMoviesByPriceAccending();
        IEnumerable<Movie> GetAllMoviesByPriceDescending();
        IEnumerable<Movie> GetAllMoviesByGeoLocationCountry(string country);
        IEnumerable<Movie> GetAllMoviesForWishlist();
        IEnumerable<Movie> GetTopPopularMovies();
        IEnumerable<Movie> GetTopPopularMoviesByBestSellingDirector(int directorId);
    }
}
