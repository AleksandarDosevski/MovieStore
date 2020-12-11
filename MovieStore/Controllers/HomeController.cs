using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using MovieStore.Data.Entities;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly IWishlistService _wishlistService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IShoppingCartService _shoppingCartService;

        public HomeController(
            IMovieService movieService,
            IDirectorService directorService,
            IWishlistService wishlistService,
            IHttpContextAccessor httpContextAccessor,
            IShoppingCartService shoppingCartService
            )
        {
            _movieService = movieService;
            _directorService = directorService;
            _wishlistService = wishlistService;
            _httpContextAccessor = httpContextAccessor;
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            var GetTopMovies = _movieService.GetTopPopularMovies();
            var GetPopularDirector = _directorService.GetDirectorByPopularity();
            var GetTopPopularMoviesByBestSellingDirector = _movieService.TopPopularMoviesByBestSellingDirector(GetPopularDirector.Id);
            var GetAllMovies = _movieService.GetAllMovies();
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();

            // init movie viewmodel
            var movieViewModel = new MovieViewModel
            {
                // fill viewmodel data
                TopPopularMovies = GetTopMovies,
                TopPopularMoviesByBestSellingDirector = GetTopPopularMoviesByBestSellingDirector,
                BestSellingDirector = GetPopularDirector,
                AllMovies = GetAllMovies,
                AddToCartTotalCounter = notificationCounters
            };

            ViewData["Counter"] = notificationCounters;

            return View(movieViewModel);
        }

        [HttpPost]
        public IActionResult RefreshPartialViewNotification()
        {
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();
            ViewData["Counter"] = notificationCounters;
            return PartialView("Notification");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public int AddToCartNotificationsCounterTest()
        {
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();
            return notificationCounters;
        }

        [HttpPost]
        public JsonResult AddToWishlist(int id)
        {
            // get movie
            var getMovieById = _movieService.GetMovieById(id);

            var CheckIfExistsInWishlist = _wishlistService.GetWishlistByMovieId(id);

            if (CheckIfExistsInWishlist == null)
            {
                // get logged in user id
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                // get other data ids
                var movieId = getMovieById.Id;
                var directorId = getMovieById.DirectorID;
                var categoryId = getMovieById.CategoryID;

                // init wishlist obj
                var wishlist = new Wishlist
                {
                    UserId = userId,
                    MovieId = movieId,
                    DirectorId = directorId,
                    CategoryId = categoryId,
                    DateAdded = DateTime.Now
                };

                // add to wishlist
                _wishlistService.Add(wishlist);

                return new JsonResult(new { data = wishlist });
            }
            else
            {
                return new JsonResult(new { data = "" });
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
