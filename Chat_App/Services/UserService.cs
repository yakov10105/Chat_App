using Chat_App.Data.IRepository;
using Chat_App.Models;
using System.Collections.Generic;

namespace Chat_App.Services
{
    public class UserService: IUserRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>();
            //Code to get it from the data base
            return users;
        }

        public User GetUserById(int id)
        {
            return new User { Id = 0, FirstName = "Yossi" };
        }
    }
}
