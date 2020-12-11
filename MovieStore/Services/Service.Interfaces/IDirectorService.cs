using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IDirectorService
    {
        void Add(Director director);
        void Edit(Director director);
        void Delete(Director director);

        IEnumerable<Director> GetDirectors();
        Director GetDirectorById(int id);
        Director GetDirectorByPopularity();
    }
}
