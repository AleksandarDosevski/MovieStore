using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Repositories.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }

        public void EditUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            var result = _context.Users.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<User> GetUsers()
        {
            var result = _context.Users.AsEnumerable();
            return result;
        }

        public IQueryable<User> GetUsersQueryable()
        {
            var result = _context.Users.AsQueryable();
            return result;
        }
    }
}
