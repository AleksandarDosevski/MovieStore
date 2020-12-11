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
    public class WishlistService : IWishlistService
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IWishlistRepository _wishlistRepository;
        private UserManager<IdentityUser> _userManager;

        public WishlistService(
            IMovieRepository movieRepository,
            IWishlistRepository wishlistRepository,
            UserManager<IdentityUser> userManager)
        {
            _movieRepository = movieRepository;
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
        }

        public void Add(Wishlist wishlist)
        {
            _wishlistRepository.Add(wishlist);
        }

        public void Delete(int id)
        {
            _wishlistRepository.Delete(id);
        }

        public void DeleteByMovieId(int movieID)
        {
            _wishlistRepository.DeleteByMovieId(movieID);
        }

        public void Edit(Wishlist wishlist)
        {
            _wishlistRepository.Edit(wishlist);
        }

        public IEnumerable<Wishlist> GetAllWishlistByUserId(string userId)
        {
            var result = _wishlistRepository.GetAllWishlistByUserId(userId);
            return result;
        }

        public IEnumerable<Wishlist> GetAllWishlists()
        {
            var result = _wishlistRepository.GetAllWishlists();
            return result;
        }

        public Wishlist GetWishlistByMovieId(int movieID)
        {
            var result = _wishlistRepository.GetWishlistByMovieId(movieID);
            return result;
        }

        public Wishlist GetWishlistById(int id)
        {
            var result = _wishlistRepository.GetWishlistById(id);
            return result;
        }
    }
}
