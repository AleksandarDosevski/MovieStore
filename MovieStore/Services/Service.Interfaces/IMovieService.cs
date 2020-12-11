using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IMovieService
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieID);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
        IQueryable<Movie> GetAllMoviesQueryable();


        IEnumerable<Movie> GetAllMoviesByUser(User user);
        IEnumerable<Movie> GetAllMoviesByUserId(int userID);
        IEnumerable<Movie> GetAllMoviesByDateDescending();
        IEnumerable<Movie> GetAllMoviesByDateAccending();
        IEnumerable<Movie> GetAllMoviesFromToDateByUserId(int userID, DateTime from, DateTime to);
        IEnumerable<Movie> GetAllMoviesByPriceAccending();
        IEnumerable<Movie> GetAllMoviesByPriceDescending();
        IEnumerable<Movie> GetAllMoviesByGeoLocationCountry(string country);
        IEnumerable<Movie> GetTopPopularMovies();
        IEnumerable<Movie> TopPopularMoviesByBestSellingDirector(int directorID);
    }
}
