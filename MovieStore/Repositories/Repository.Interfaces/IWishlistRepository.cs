using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories.Repository.Interfaces
{
    public interface IWishlistRepository
    {
        void Add(Wishlist wishlist);
        void Edit(Wishlist wishlist);
        void Delete(int id);
        IEnumerable<Wishlist> GetAllWishlists();
        Wishlist GetWishlistById(int id);
        

        Wishlist GetWishlistByMovieId(int movieID);
        void DeleteByMovieId(int movieID);      
        
        // Important
        IEnumerable<Wishlist> GetAllWishlistByUserId(string userId);
    }
}
