using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Data.Entities;
using MovieStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MovieStore.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _searchService.GetAllMovies();
            return result;
        }

        
        public Movie GetMovie(int id)
        {
            var result = _searchService.GetMovie(id);
            return result;
        }

       
        public JsonResult Search(string keywords, string title, string director, string category)
        {
            List<string> keywordsList = new List<string>();

            if (keywords != "undefined")
            {
                keywordsList = keywords.Split(" ").ToList();
            }

            List<Movie> SearchResults = new List<Movie>();

            SearchResults = SearchJobPostsBy(keywordsList, title, director, category);

            return Json(new { data = SearchResults });
        }

        #region Helpers

        private List<Movie> SearchJobPostsBy(List<string> keywords, string title, string director, string category)
        {
            var result = _searchService.SearchMovies(keywords, title, director, category).ToList();
            return result;
        }

        #endregion
    }
}