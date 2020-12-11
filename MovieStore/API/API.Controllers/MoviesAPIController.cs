using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.API.API.Controllers
{
    [Route("api/MoviesAPI")]
    [ApiController]
    public class MoviesAPIController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesAPIController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/MoviesAPI
        [HttpGet("Movies")]
        public IEnumerable<Movie> GetMovies()
        {
            var movies = _movieService.GetAllMovies();
            return movies;
        }

        // GET: api/MoviesAPI/5
        [HttpGet("Movie")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var movie = _movieService.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }

        // PUT: api/MoviesAPI/5
        [HttpPost("EditMovie")]
        public IActionResult EditMovie(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }

            try
            {
                _movieService.EditMovie(movie);
                return Ok(movie);
            }
            catch (Exception ex)
            {
               throw new ArgumentException($"Error occured:  {ex}.");
            }
        }

        // POST: api/MoviesAPI
        [HttpPost("AddMovie")]
        public ActionResult<Movie> AddMovie(Movie movie)
        {
            _movieService.AddMovie(movie);
            return CreatedAtAction("AddMovie", new { id = movie.Id }, movie);
        }

        // DELETE: api/MoviesAPI/5
        [HttpDelete("DeleteMovie")]
        public ActionResult<Movie> DeleteMovie(int id)
        {
            _movieService.DeleteMovie(id);
            // 204 No Content is a popular response for DELETE
            // or return Ok();
            return NoContent();
        }

    }
}
