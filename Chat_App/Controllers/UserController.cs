using Chat_App.Data.Repository;
using Chat_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chat_App.Controllers
{
    //api/[name of the controller]
    //now it will be Users and it will be changed if we change the name of the controller class
    //we can hard code it to like: "api/the name of the route we want"
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase // ControllerBase Without view Support
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        //GET api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _repository.GetAllUsers();

            return Ok(users);
        }

        //GET api/Users/{id}
        //GET api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _repository.GetUserById(id);

            return Ok(user);
        }
    }
}
