using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IWishlistRepository _wishlistRepository;
        private UserManager<IdentityUser> _userManager;

        public ShoppingCartService(
            IShoppingCartRepository shoppingCartRepository,
            IMovieRepository movieRepository,
            IWishlistRepository wishlistRepository,
            UserManager<IdentityUser> userManager
            )
        {
            _shoppingCartRepository = shoppingCartRepository;
            _movieRepository = movieRepository;
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
        }

        public void Add(ShoppingCart shoppingCart)
        {
            _shoppingCartRepository.Add(shoppingCart);
        }

        public void Delete(int id)
        {
            _shoppingCartRepository.Delete(id);
        }

        public void DeleteByMovieId(int movieID)
        {
            _shoppingCartRepository.DeleteByMovieId(movieID);
        }

        public IEnumerable<ShoppingCart> GetAllItemsInCart()
        {
            var result = _shoppingCartRepository.GetAllItemsInCart();
            return result;
        }

        public IEnumerable<ShoppingCart> GetAllItemsInCartByUserId(string userId)
        {
            var result = _shoppingCartRepository.GetAllItemsInCartByUserId(userId);
            return result;
        }

        public ShoppingCart GetShoppingCartById(int id)
        {
            var result = _shoppingCartRepository.GetShoppingCartById(id);
            return result;
        }
    }
}
