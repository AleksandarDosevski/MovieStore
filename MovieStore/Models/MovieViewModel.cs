using MovieStore.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MovieViewModel
    {
        // Movie Data

        [Display(Name = "Movie ID")]
        public int MovieID { get; set; }

        [Display(Name = "Title")]
        [StringLength(350)]
        public string Title { get; set; }

        [Display(Name = "Year")]
        public DateTime YearOfRelease { get; set; }

        [Display(Name = "User ID")]
        public int UserId { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Language")]
        [StringLength(50)]
        public string Language { get; set; }

        [Display(Name = "Country")]
        [StringLength(150)]
        public string Country { get; set; }


        [Display(Name = "Copies")]
        public int Copies { get; set; }

        [Display(Name = "Shipping")]
        [StringLength(50)]
        public string Shipping { get; set; }

        [Display(Name = "Photo Cover")]
        public string MainPhotoURL { get; set; }

        [Display(Name = "Photos")]
        public List<Photo> Photos { get; set; }

        // Director Data
        [Display(Name = "Director")]
        [StringLength(350)]
        public string DirectorName { get; set; }

        [Display(Name = "Director ID")]
        public int DirectorID { get; set; }

        [Display(Name = "Director")]
        public Director Director { get; set; }

        [Display(Name = "Directors List")]
        public IEnumerable<SelectListItem> Directors { get; set; }

        public string CreateDirectorName { get; set; }
        public string CreateDirectorShortDescription { get; set; }


        // Category Data
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Display(Name = "Categories")]
        public IEnumerable<SelectListItem> Categories { get; set; }

        [Display(Name = "Category")]
        public Category Category { get; set; }

        [Display(Name = "Category")]
        [StringLength(150)]
        public string CategoryName { get; set; }

        public string CreateCategoryName { get; set; }

        // Photos Data
        [Display(Name = "Photo Cover")]
        public string PhotoURL { get; set; }
        public bool IsMainPhoto { get; set; }
        [Display(Name = "Photo Description")]
        public string DescriptionPhoto { get; set; }

        // Wishlist Data
        public double WishlistTotalPrice { get; set; }

        // Shopping Cart Data
        public int AddToCartTotalCounter { get; set; }


        // Other Landing Page Data
        public IEnumerable<Movie> TopPopularMovies { get; set; }
        public IEnumerable<Movie> TopPopularMoviesByBestSellingDirector { get; set; }
        public Director BestSellingDirector { get; set; }
        public IEnumerable<Movie> AllMovies { get; set; }
        public IEnumerable<Movie> AllMoviesFromWishlistByLoggedInUser { get; set; }
    }
}
