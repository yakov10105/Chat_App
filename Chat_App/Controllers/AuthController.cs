using Chat_App.Data;
using Chat_App.Dtos;
using Chat_App.Models;
using Chat_App.Services.Auth;
using Chat_App.Services.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _iAuthService;
        private readonly IJwtService _iJwtService;
        private readonly IUserRepo _iUserRepo;

        public AuthController(IAuthenticationService iAuth, IJwtService iJwtService, IUserRepo iUserRepo)
        {
            _iAuthService = iAuth;
            _iJwtService = iJwtService;
            _iUserRepo = iUserRepo;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDto loginUser)
        {
            var user = _iAuthService.AuthenticateEmail(loginUser);
            if (user == null) return BadRequest(error: new { message = "Invalid Cardentials" });
            if (!_iAuthService.AuthenticatePassword(loginUser, user))
                return BadRequest(error: new { message = "Invalid Cardentials" });

            var jwtKey = _iJwtService.Generate(user.Id);

            Response.Cookies.Append("jwt", jwtKey, new CookieOptions
            {
                HttpOnly = true
            });

            return Ok(new
            {
                message = "Success"
            });

        }

        [AllowAnonymous]
        [HttpPost("register")]
        public IActionResult Register(UserRegisterDto regUser)
        {
            return Created("Success", _iAuthService.RegisterUser(regUser));
        }
        [Authorize]
        [HttpGet("user")]
        public IActionResult User()
        {
            //try
            //{
            //    var jwt = Request.Cookies["jwt"];

            //    var token = _iJwtService.Verify(jwt);

            //    int userId = int.Parse(token.Issuer);

            //    var user = _iUserRepo.GetUserById(userId);

            //    var sUser = new UserReadDto
            //    {
            //        FirstName = user.FirstName,
            //        LastName = user.LastName,
            //        Id = user.Id,
            //        IsOnline = user.IsOnline,
            //        RoomId = user.RoomId,
            //        UserAge = user.UserAge,
            //        UserEmail = user.UserEmail,
            //        UserName = user.UserName,
            //        WinCoins = user.WinCoins
            //    };

            //    return Ok(sUser);
            //}
            //catch (Exception)
            //{
            //    return Unauthorized();
            //}
            return Ok(new { authorized = "Successs" });

        }
    }

}
