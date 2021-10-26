using Chat_App.Models;
using System.Collections.Generic;
using System;


namespace Chat_App.Data
{
	public interface IUserRepo
	{
		IEnumerable<User> GetAllUsers();

		User GetUserById(int id);
	}
}

