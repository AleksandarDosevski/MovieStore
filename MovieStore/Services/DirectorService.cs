using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void Add(Director director)
        {
            _directorRepository.Add(director);
        }

        public void Delete(Director director)
        {
            _directorRepository.Delete(director);
        }

        public void Edit(Director director)
        {
            _directorRepository.Edit(director);
        }

        public Director GetDirectorById(int id)
        {
            var result = _directorRepository.GetDirectorById(id);
            return result;
        }

        public Director GetDirectorByPopularity()
        {
            var result = _directorRepository.GetDirectorByPopularity();
            return result;
        }

        public IEnumerable<Director> GetDirectors()
        {
            var result = _directorRepository.GetDirectors();
            return result;
        }
    }
}
