using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IPreOrderService
    {
        void Add(PreOrder preOrder);
        void Edit(PreOrder preOrder);
        void Delete(int id);
        void DeleteByMovieId(int movieID);
        void DeleteByUserId(string userID);

        PreOrder GetPreOrderById(int id);
        PreOrder GetPreOrderByMovieId(int movieID);
        PreOrder GetPreOderByUserId(string userID);

        IEnumerable<PreOrder> GetAllPreOrders();
        IEnumerable<PreOrder> GetAllPreOrdersByUserId(string userID);
        IEnumerable<PreOrder> GetAllPreOrdersByMovieId(string movieID);
        IQueryable<PreOrder> GetAllPreOrdersQueryable();
    }
}
