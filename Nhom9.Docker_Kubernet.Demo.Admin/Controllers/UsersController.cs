using DnsClient.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nhom9.Docker_Kubernet.Demo.UserService.Utils;
using Nhom9.Docker_Kubernet.Demo.AuthenticationService.AuthenticationConfig;
using Nhom9.Docker_Kubernet.Demo.DL.Repositories;
using Nhom9.Docker_Kubernet.Demo.Entity.DTO;
using Nhom9.Docker_Kubernet.Demo.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom9.Docker_Kubernet.Demo.UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserRepository _userRepository;
        private readonly Authentication _authentication;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IWebHostEnvironment env,
            Authentication authentication,
            UserRepository userRepository, 
            ILogger<UsersController> logger)
        {
            _config = Utils.Environment.GetConfiguration(env);
            _userRepository = userRepository;
            _logger = logger;
            _authentication = authentication;
        }


        [HttpGet]
        [Route("healthz")]
        public string Healthz()
        {
            return "User service active";
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserDTO userLogin)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var user = _userRepository.AuthenticateUser(userLogin.Username, userLogin.Password);
                if (user == null) return BadRequest("Account don't exits");

                var token = _authentication.GenerateJwtToken(user.Fullname, user.UserID);
                if (token == null) return Unauthorized();
                return Ok(token);
            }
            catch(Exception ex)
            {
                _logger.LogError($"{ex}");
                return BadRequest($"{ex}");

            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var userID = Request.HttpContext.Items["x-userID"]?.ToString();
                if(userID == null) { return Unauthorized(); }
                var users = await _userRepository.GetAll();
                return Ok(users);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{page}")]
        public async Task<IActionResult> GetUserBySkipTake(int page)
        {
            try
            {
                var userID = Request.HttpContext.Items["x-userID"]?.ToString();
                if (userID == null) { return Unauthorized(); }
                var users = await _userRepository.GetSkipTake(page);
                return Ok(users);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string userID)
        {
            try
            {
                var userId = Request.HttpContext.Items["x-userID"]?.ToString();
                if (userId == null) { return Unauthorized(); }
                var users = await _userRepository.Delete(userID);
                return Ok(userID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditUser(User user)
        {
            try
            {
                var userID = Request.HttpContext.Items["x-userID"]?.ToString();
                if (userID == null) { return Unauthorized(); }
                await _userRepository.UpdateUser(user);
                return Ok(user.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertUser(User user)
        {
            try
            {
                var userID = Request.HttpContext.Items["x-userID"]?.ToString();
                if (userID == null) { return Unauthorized(); }
                await _userRepository.Insert(user);
                return Ok(user.UserID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }
    }
}
