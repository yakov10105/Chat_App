using Chat_App.Data.DbConfig;
using Chat_App.Data.Repository;
using Chat_App.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Chat_App.Services
{
    public class UserService: IUserRepository
    {
        private readonly ChatAppDbContext _dbContext;

        public UserService(ChatAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }

        public User GetUserById(int id)
        {
            var user = _dbContext.Users
                .FirstOrDefault(u => u.Id == id);
            if (user != null)
                return user;
            else return null;
        }

        public bool AddUser(User user)
        {
            try
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public bool RemoveUser(int userId)
        {

            try
            {
                _dbContext.Users.Remove(_dbContext.Users.FirstOrDefault(u =>u.Id == userId));
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _dbContext.Users.Update(user);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
