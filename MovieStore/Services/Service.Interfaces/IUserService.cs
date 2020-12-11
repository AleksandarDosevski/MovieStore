using MovieStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Services.Service.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(User user);

        IEnumerable<User> GetUsers();
        IQueryable<User> GetUsersQueryable();

        User GetUserById(int id);
    }
}
