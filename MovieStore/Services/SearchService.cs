using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class SearchService : ISearchService
    {
        private readonly ISearchRepository _searchRepository;

        public SearchService(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _searchRepository.GetAllMovies();
            return result;
        }

        public Movie GetMovie(int id)
        {
            var result = _searchRepository.GetMovie(id);
            return result;
        }

        public IEnumerable<Movie> SearchMovies(List<string> keywords, string title, string director, string category)
        {
            var result = _searchRepository.SearchMovies(keywords, title, director, category);
            return result;
        }
    }
}
