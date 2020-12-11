using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var order = GetOrderById(id);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void DeleteByMovieId(int movieID)
        {
            var order = GetOrderByMovieId(movieID);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void DeleteByUserId(string userID)
        {
            var order = GetOrderByUserId(userID);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void Edit(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var result = _context.Orders.AsEnumerable();
            return result;
        }

        public IEnumerable<Order> GetAllOrdersByMovieId(int movieID)
        {
            var result = _context.Orders.AsEnumerable().Where(x => x.MovieId == movieID);
            return result;
        }

        public IEnumerable<Order> GetAllOrdersByUserId(string userID)
        {
            var result = _context.Orders.AsEnumerable().Where(x => x.UserId == userID);
            return result;
        }

        public IQueryable<Order> GetAllOrdersQueryable()
        {
            var result = _context.Orders.AsQueryable();
            return result;
        }

        public Order GetOrderByUserId(string userID)
        {
            var result = _context.Orders.FirstOrDefault(x => x.UserId == userID);
            return result;
        }

        public Order GetOrderById(int id)
        {
            var result = _context.Orders.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public Order GetOrderByMovieId(int movieID)
        {
            var result = _context.Orders.FirstOrDefault(x => x.MovieId == movieID);
            return result;
        }

    }
}
