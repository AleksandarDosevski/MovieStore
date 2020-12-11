using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IOrderService
    {
        void Add(Order order);
        void Edit(Order order);
        void Delete(int id);
        void DeleteByMovieId(int movieID);
        void DeleteByUserId(string userID);

        Order GetOrderById(int id);
        Order GetOrderByMovieId(int movieID);
        Order GetOrderByUserId(string userID);

        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetAllOrdersByUserId(string userID);
        IEnumerable<Order> GetAllOrdersByMovieId(int movieID);
        IQueryable<Order> GetAllOrdersQueryable();
    }
}
