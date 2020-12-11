using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MovieStore.Data.Entities;
using MovieStore.Models;
using MovieStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieStore.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IDirectorService _directorService;
        private readonly IWishlistService _wishlistService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IShoppingCartService _shoppingCartService;

        public ShopCartController(
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

        // GET: ShopCart
        public ActionResult Index()
        {
            // init new array of movies
            List<Movie> AllMovieListFromCartByLoggedInUser = new List<Movie>();
            var TotalPriceCount = 0.0;
            var TotalShipping = 0.0;
            var NotificationCounter = 0;

            // get logged in user id
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var itemsInCart = _shoppingCartService.GetAllItemsInCartByUserId(userId);

            foreach (var item in itemsInCart)
            {
                var movie = _movieService.GetMovieById(item.MovieId);
                if (movie != null)
                {
                    AllMovieListFromCartByLoggedInUser.Add(movie);
                }
            }

            TotalPriceCount = TotalShipping + Math.Round(AllMovieListFromCartByLoggedInUser.Sum(x => x.Price), 2);
            NotificationCounter = _shoppingCartService.GetAllItemsInCart().Count();

            var shopCartViewModel = new ShopCartViewModel()
            {
                SubTotal = Math.Round(AllMovieListFromCartByLoggedInUser.Sum(x => x.Price), 2),
                ShippingTotal = 0.0,
                TotalPrice = TotalPriceCount,
                AllMoviesAddedToCartByLoggedInUser = AllMovieListFromCartByLoggedInUser,
                AddToCartTotalCounter = NotificationCounter
            };

            ViewData["Counter"] = NotificationCounter;

            return View(shopCartViewModel);
        }

        public JsonResult AddToCart(int id)
        {
            // get movie
            var getMovieById = _movieService.GetMovieById(id);
            // get logged in user id
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            // get other data ids
            var movieId = getMovieById.Id;
            var directorId = getMovieById.DirectorID;
            var categoryId = getMovieById.CategoryID;

            // init shopping cart obj
            var shoppingCart = new ShoppingCart
            {
                UserId = userId,
                MovieId = movieId,
                Price = getMovieById.Price,
                DateAdded = DateTime.Now
            };

            // add to shopping cart
            _shoppingCartService.Add(shoppingCart);

            return new JsonResult(new { data = shoppingCart });
        }

 
        [HttpPost]
        public JsonResult Delete(int Id)
        {
            var getMovie = _movieService.GetMovieById(Id);

            _shoppingCartService.DeleteByMovieId(Id);
            // ~/ShopCart/Index
            return new JsonResult(new { data = getMovie, url = Url.Action("Index", "ShopCart") });
        }

        public IActionResult Buy()
        {
            return RedirectToAction("Index", "Order");
        }

        // POST: ShopCart/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}