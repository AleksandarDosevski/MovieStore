using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories
{
    public class WishlistRepository : IWishlistRepository
    {
        private readonly DataContext _context;

        public WishlistRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Wishlist wishlist)
        {
            _context.Wishlists.Add(wishlist);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var wishlist = GetWishlistById(id);
            _context.Wishlists.Remove(wishlist);
            _context.SaveChanges();
        }

        public void DeleteByMovieId(int Id)
        {
            // treba da se doraboti
            var wishlist = GetWishlistByMovieId(Id);
            _context.Wishlists.Remove(wishlist);
            _context.SaveChanges();
        }

        public void Edit(Wishlist wishlist)
        {
            _context.Wishlists.Update(wishlist);
            _context.SaveChanges();
        }

        // Important
        public IEnumerable<Wishlist> GetAllWishlistByUserId(string userId)
        {
            // Use of MoreLinq Library from NuGet Package (DistinctBy)
            var result = _context.Wishlists.AsEnumerable().Where(x => x.UserId == userId).DistinctBy(x => x.MovieId);
            return result;
        }

        public IEnumerable<Wishlist> GetAllWishlists()
        {
            var result = _context.Wishlists.AsEnumerable();
            return result;
        }

        public Wishlist GetWishlistById(int id)
        {
            var result = _context.Wishlists.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Wishlist GetWishlistByMovieId(int movieID)
        {
            var result = _context.Wishlists.FirstOrDefault(x => x.MovieId == movieID);
            return result;
        }
    }
}
