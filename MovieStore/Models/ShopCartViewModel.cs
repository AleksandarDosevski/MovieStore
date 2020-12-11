using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class ShopCartViewModel
    {
        // Movie Data
        public int MovieID { get; set; }
        public string Title { get; set; }
        public DateTime YearOfRelease { get; set; }
        public double Price { get; set; }
        public string MovieType { get; set; }
        public string Shipping { get; set; }
        public string MainPhotoURL { get; set; }

        // Director Data
        public string DirectorName { get; set; }
        public int DirectorID { get; set; }

        // Category Data
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // Wishlist Data
        public double WishlistTotalPrice { get; set; }

        // Order Data
        public double SubTotal { get; set; }
        public double ShippingTotal { get; set; }
        public double TotalPrice { get; set; }
        public double AddToCartTotalCounter { get; set; }

        // Other Data
        public IEnumerable<Movie> AllMovies { get; set; }
        public IEnumerable<Movie> AllMoviesFromWishlistByLoggedInUser { get; set; }
        public IEnumerable<Movie> AllMoviesAddedToCartByLoggedInUser { get; set; }
    }
}
