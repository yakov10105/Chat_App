using Chat_App.Models;
using System.Collections.Generic;

namespace Chat_App.Data.IRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int id);
    }
}
