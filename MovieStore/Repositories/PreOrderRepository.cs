using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories
{
    public class PreOrderRepository : IPreOrderRepository
    {
        private readonly DataContext _context;

        public PreOrderRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(PreOrder preOrder)
        {
            _context.PreOrders.Add(preOrder);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var preOrder = GetPreOrderById(id);
            _context.PreOrders.Remove(preOrder);
            _context.SaveChanges();
        }

        public void DeleteByMovieId(int movieID)
        {
            var preOrder = GetPreOrderByMovieId(movieID);
            _context.PreOrders.Remove(preOrder);
            _context.SaveChanges();
        }

        public void DeleteByUserId(string userID)
        {
            var preOrder = GetPreOrderByUserId(userID);
            _context.PreOrders.Remove(preOrder);
            _context.SaveChanges();
        }

        public void Edit(PreOrder preOrder)
        {
            _context.PreOrders.Update(preOrder);
            _context.SaveChanges();
        }

        public IEnumerable<PreOrder> GetAllPreOrders()
        {
            var result = _context.PreOrders.AsEnumerable();
            return result;
        }

        public IEnumerable<PreOrder> GetAllPreOrdersByMovieId(int movieID)
        {
            var result = _context.PreOrders.AsEnumerable().Where(x => x.MovieId == movieID);
            return result;
        }

        public IEnumerable<PreOrder> GetAllPreOrdersByUserId(string userID)
        {
            var result = _context.PreOrders.AsEnumerable().Where(x => x.UserId == userID);
            return result;
        }

        public IQueryable<PreOrder> GetAllPreOrdersQueryable()
        {
            var result = _context.PreOrders.AsQueryable();
            return result;
        }

        public PreOrder GetPreOrderByUserId(string userID)
        {
            var result = _context.PreOrders.FirstOrDefault(x => x.UserId == userID);
            return result;
        }

        public PreOrder GetPreOrderById(int id)
        {
            var result = _context.PreOrders.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public PreOrder GetPreOrderByMovieId(int movieID)
        {
            var result = _context.PreOrders.FirstOrDefault(x => x.MovieId == movieID);
            return result;
        }
    }
}
