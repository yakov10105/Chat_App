using Chat_App.Models;
using System.Collections.Generic;
using System;


namespace Chat_App.Data
{
    public class UserRepo : IUserRepo
    {
        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>();
            //Code to get it from the data base
            return users;
        }

        public User GetUserById(int id)
        {
            return new User { UserId=0, FirstName="Yossi"};
        }
    }
}