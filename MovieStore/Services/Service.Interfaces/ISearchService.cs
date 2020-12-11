using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services.Service.Interfaces
{
    public interface ISearchService
    {
        IEnumerable<Movie> SearchMovies(List<string> keywords, string title, string director, string category);
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovie(int id);
    }
}
