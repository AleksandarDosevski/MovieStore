using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using MovieStore.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            _orderRepository.Add(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public void DeleteByMovieId(int movieID)
        {
            _orderRepository.DeleteByMovieId(movieID);
        }

        public void DeleteByUserId(string userID)
        {
            _orderRepository.DeleteByUserId(userID);
        }

        public void Edit(Order order)
        {
            _orderRepository.Edit(order);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var result = _orderRepository.GetAllOrders();
            return result;
        }

        public IEnumerable<Order> GetAllOrdersByMovieId(int movieID)
        {
            var result = _orderRepository.GetAllOrdersByMovieId(movieID);
            return result;
        }

        public IEnumerable<Order> GetAllOrdersByUserId(string userID)
        {
            var result = _orderRepository.GetAllOrdersByUserId(userID);
            return result;
        }

        public IQueryable<Order> GetAllOrdersQueryable()
        {
            var result = _orderRepository.GetAllOrdersQueryable();
            return result;
        }

        public Order GetOrderById(int id)
        {
            var result = _orderRepository.GetOrderById(id);
            return result;
        }

        public Order GetOrderByMovieId(int movieID)
        {
            var result = _orderRepository.GetOrderByMovieId(movieID);
            return result;
        }

        public Order GetOrderByUserId(string userID)
        {
            var result = _orderRepository.GetOrderByUserId(userID);
            return result;
        }
    }
}
