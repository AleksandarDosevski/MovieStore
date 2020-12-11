using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Services.Service.Interfaces;
using MovieStore.Models;
using System.IO;
using System.Net.Http.Headers;
using NPOI.SS.Formula.Functions;
using Microsoft.Extensions.Logging;
using MovieStore.Logger;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace MovieStore.Controllers
{
    [Authorize(Roles = "admin, editor")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICategoryService _categoryService;
        private readonly IDirectorService _directorService;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(
            IMovieService movieService,
            ICategoryService categoryService,
            IDirectorService directorService,
            ILogger<MoviesController> logger
        )
        {
            _movieService = movieService;
            _categoryService = categoryService;
            _directorService = directorService;
            _logger = logger;
        }


        // GET: Movies
        public IActionResult Index()
        {
            var movieList = _movieService.GetAllMovies();
            if (movieList != null)
            {
                _logger.LogInformation(LoggerMessageDisplay.MoviesListed);
            }
            else
            {
                _logger.LogInformation(LoggerMessageDisplay.NoMoviesInDB);
            }
            return View(movieList);
        }

        [HttpGet]
        public JsonResult FillMoviesDataTable()
        {
            var movielist = _movieService.GetAllMovies();
            return Json(new { data = movielist });
        }

        // GET: Movies/Details/5
        public IActionResult Details(int id)
        {
            var movie = _movieService.GetMovieById(id);
            _logger.LogInformation(LoggerMessageDisplay.MovieFoundDisplayDetails);

            if (movie == null)
            {
                _logger.LogWarning(LoggerMessageDisplay.NoMovieFound);
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Details/5
        public JsonResult DetailMovieDataTable(int id)
        {
            var movie = _movieService.GetMovieById(id);
            _logger.LogInformation(LoggerMessageDisplay.MovieFoundDisplayDetails);

            if (movie == null)
            {
                _logger.LogWarning(LoggerMessageDisplay.NoMovieFound);
                throw new ArgumentNullException("NoMovieFound");
            }

            return Json(new { detailsData = movie });
        }

        // GET: Movies/Create
        [Authorize(Roles = "admin")]    
        public IActionResult Create()
        {
            var Categories = _categoryService.GetCategories();
            var Directors = _directorService.GetDirectors();

            MovieViewModel movieViewModel = new MovieViewModel
            {
                Categories = GetSelectListItemsCategory(Categories),
                Directors = GetSelectListDirectors(Directors),
            };

            return View(movieViewModel);
        }

        private IEnumerable<SelectListItem> GetSelectListItemsCategory(IEnumerable<Category> categories)
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select category..."
                }
            };
            foreach (var element in categories)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }

        private IEnumerable<SelectListItem> GetSelectListDirectors(IEnumerable<Director> directors)
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "0",
                    Text = "Select director..."
                }
            };
            foreach (var element in directors)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Name
                });
            }
            return selectList;
        }


        // POST: Movies/Create
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MovieViewModel movieViewModel)
        {
            var movie = new Movie();

            if (ModelState.IsValid)
            {
                movie.CategoryID = movieViewModel.CategoryID;
                movie.CategoryName = movieViewModel.CategoryName;
                movie.Copies = movieViewModel.Copies;
                movie.Country = movieViewModel.Country;
                movie.Description = movieViewModel.Description;
                movie.Language = movieViewModel.Language;
                movie.Price = movieViewModel.Price;
                movie.Shipping = movieViewModel.Shipping;
                movie.Title = movieViewModel.Title;
                movie.YearOfRelease = movieViewModel.YearOfRelease;
                movie.UserId = movieViewModel.UserId;
                movie.DirectorID = movieViewModel.DirectorID;
                movie.DirectorName = movieViewModel.DirectorName;
                movie.PhotoURL = movieViewModel.PhotoURL;

                _movieService.AddMovie(movie);
                _logger.LogInformation(LoggerMessageDisplay.MovieCreated);
                return RedirectToAction(nameof(Index));
            }
            _logger.LogError(LoggerMessageDisplay.MovieNotCreatedModelStateInvalid);
            return View(movie);
        }


        [HttpPost]
        public IActionResult UploadPhoto()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    //var dbPath = Path.Combine(folderName, fileName);
                    var dbPath = fileName;

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    _logger.LogInformation(LoggerMessageDisplay.PhotoUploaded);
                    return Ok(new { dbPath });
                }
                else
                {
                    _logger.LogError(LoggerMessageDisplay.PhotoUploadedError);
                    return BadRequest();
                }
            }
            catch (System.Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.PhotoUploadedError + " --->" + ex);
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: Movies/Edit/5
        public IActionResult Edit(int id)
        {
            var movie = _movieService.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                _logger.LogWarning(LoggerMessageDisplay.MovieEditNotFound);
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _movieService.EditMovie(movie);
                    _logger.LogInformation(LoggerMessageDisplay.MovieEdited);
                }
                catch (Exception ex)
                {
                    _logger.LogInformation(LoggerMessageDisplay.MovieEditErrorModelStateInvalid + " ---> " + ex);
                    throw;
                }
                _logger.LogError(LoggerMessageDisplay.MovieEditErrorModelStateInvalid);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _movieService.DeleteMovie(id);
                _logger.LogInformation(LoggerMessageDisplay.MovieDeleted);
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggerMessageDisplay.MovieDeletedError + " ---> " + ex);
                throw;
            }

            _logger.LogError(LoggerMessageDisplay.MovieDeletedError);
            return RedirectToAction(nameof(Index));
        }

    }
}
