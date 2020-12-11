using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MovieStore.Data.Entities;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieStore.Controllers
{
    [Authorize]
    public class WishListController : Controller
    {
        private readonly IWishlistService _wishlistService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMovieService _movieService;
        private readonly IShoppingCartService _shoppingCartService;

        public WishListController(
            IWishlistService wishlistService,
            IHttpContextAccessor httpContextAccessor,
            IMovieService movieService,
            IShoppingCartService shoppingCartService)
        {
            _wishlistService = wishlistService;
            _httpContextAccessor = httpContextAccessor;
            _movieService = movieService;
            _shoppingCartService = shoppingCartService;
        }

        // GET: Wishlist/Index
        public IActionResult Index()
        {
            // init new array of movies
            List<Movie> AllMovieListFromWishlistByLoggedInUser = new List<Movie>();
            var TotalPriceCount = 0.0;

            // get logged in user id
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var wishlists = _wishlistService.GetAllWishlistByUserId(userId);

            foreach (var item in wishlists)
            {
                var movie = _movieService.GetMovieById(item.MovieId);
                if (movie != null)
                {
                    AllMovieListFromWishlistByLoggedInUser.Add(movie);
                }
            }

            TotalPriceCount = Math.Round(AllMovieListFromWishlistByLoggedInUser.Sum(x => x.Price), 2);

            // init viewmodel
            var movieViewModel = new MovieViewModel();
            movieViewModel.AllMoviesFromWishlistByLoggedInUser = AllMovieListFromWishlistByLoggedInUser;
            movieViewModel.WishlistTotalPrice = TotalPriceCount;

            return View(movieViewModel);
        }

        public IActionResult Details(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        [HttpPost]
        public JsonResult Delete(int Id)
        {
            var getMovie = _movieService.GetMovieById(Id);

            _wishlistService.DeleteByMovieId(Id);

            return new JsonResult(new { data = getMovie, url = Url.Action("Index", "WishList") });
        }

        public JsonResult AddToCartFromWishlist(List<string> movieIds)
        {
            // add to temporary list
            List<string> movieIds_temp = movieIds;
            // get all movie ids from movieIds / wishlist
            // and add to shopping cart table
            foreach (var movie in movieIds_temp)
            {
                var getMovie = _movieService.GetMovieById(int.Parse(movie));

                // get logged in user id
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                // get other data ids
                var movieId = getMovie.Id;

                // init shopping cart obj
                var shoppingCart = new ShoppingCart
                {
                    UserId = userId,
                    MovieId = movieId,
                    Price = getMovie.Price,
                    DateAdded = DateTime.Now
                };

                // add single movie from wishlist to shopping cart
                _shoppingCartService.Add(shoppingCart);
            }

            // remove all selected items from wishlist
            foreach(var selectedItem in movieIds)
            {
                _wishlistService.DeleteByMovieId(int.Parse(selectedItem));
            }

            return new JsonResult(new { data = "" });
        }

        public IActionResult GoToCart()
        {
            return RedirectToAction("Index", "ShopCart");
        } 

    }
}

