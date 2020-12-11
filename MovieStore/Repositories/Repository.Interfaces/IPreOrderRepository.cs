using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories.Repository.Interfaces
{
    public interface IPreOrderRepository
    {
        void Add(PreOrder preOrder);
        void Edit(PreOrder preOrder);
        void Delete(int id);
        void DeleteByMovieId(int movieID);
        void DeleteByUserId(string userID);

        PreOrder GetPreOrderById(int id);
        PreOrder GetPreOrderByMovieId(int movieID);
        PreOrder GetPreOrderByUserId(string userID);

        IEnumerable<PreOrder> GetAllPreOrders();
        IEnumerable<PreOrder> GetAllPreOrdersByUserId(string userID);
        IEnumerable<PreOrder> GetAllPreOrdersByMovieId(int movieID);
        IQueryable<PreOrder> GetAllPreOrdersQueryable();
    }
}
