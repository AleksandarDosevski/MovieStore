using MovieStore.Data.Entities;
using MovieStore.Logger;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ILogger<MovieService> _logger;

        public MovieService(IMovieRepository movieRepository, ILogger<MovieService> logger)
        {
            _movieRepository = movieRepository;
            _logger = logger;
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
            _logger.LogInformation(LoggerMessageDisplay.MovieCreated);
        }

        public void DeleteMovie(int movieID)
        {
            _movieRepository.DeleteMovie(movieID);
        }

        public void EditMovie(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByDateAccending()
        {
            var result = _movieRepository.GetAllMoviesByDateAccending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByDateDescending()
        {
            var result = _movieRepository.GetAllMoviesByDateDescending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByGeoLocationCountry(string country)
        {
            var result = _movieRepository.GetAllMoviesByGeoLocationCountry(country);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByPriceAccending()
        {
            var result = _movieRepository.GetAllMoviesByPriceAccending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByPriceDescending()
        {
            var result = _movieRepository.GetAllMoviesByPriceDescending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByUser(User user)
        {
            var result = _movieRepository.GetAllMoviesByUser(user);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByUserId(int userID)
        {
            var result = _movieRepository.GetAllMoviesByUserId(userID);
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesFromToDateByUserId(int userID, DateTime from, DateTime to)
        {
            var result = _movieRepository.GetAllMoviesFromToDateByUserId(userID, from, to);
            return result;
        }

        public IQueryable<Movie> GetAllMoviesQueryable()
        {
            var result = _movieRepository.GetAllMoviesQueryable();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _movieRepository.GetMovieById(id);
            return result;
        }

        public IEnumerable<Movie> GetTopPopularMovies()
        {
            var result = _movieRepository.GetTopPopularMovies();
            return result;
        }

        public IEnumerable<Movie> TopPopularMoviesByBestSellingDirector(int directorID)
        {
            var result = _movieRepository.GetTopPopularMoviesByBestSellingDirector(directorID);
            return result;
        }
    }
}
  