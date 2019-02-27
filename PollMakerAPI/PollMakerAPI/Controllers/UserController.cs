using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PollMakerAPI.Infrastructure.Models;
using PollMakerAPI.Infrastructure.Repositories.Interfaces;
using PollMakerAPI.Infrastructure.Services.Interfaces;

namespace PollMakerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpGet("{getUser}")]
        public IActionResult GetUser(string email)
        {
            try
            {
                var user = _userService.GetUser(email);
                if (user != null)
                {
                    return new OkObjectResult(user);
                }
                return NotFound("User not found");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("createUser")]
        public async Task<IActionResult> CreateUserAsync([FromBody]User userToCreate)
        {
            try
            {
                var user = _userService.GetUser(userToCreate.Email);
                if (user == null)
                {
                    await _userService.CreateUserAsync(userToCreate);
                    return new OkObjectResult(userToCreate);
                }
                return StatusCode(StatusCodes.Status409Conflict);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("updatePassword")]
        public async Task<IActionResult> Update(string email, string oldPassword, string updatedPassword)
        {
            try
            {
                var user = _userService.GetUser(email);
                if (user != null)
                {
                    await _userService.UpdatePassword(user, oldPassword, updatedPassword);
                    return new OkObjectResult(user);
                }
                return NotFound($"User profile not found for {user.Email}");

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        public async Task<IActionResult> RemoveDeleteUser(User userToRemove)
        {
            try
            {
                var user = _userService.GetUser(userToRemove.Email);
                if (user != null)
                {
                    await _userService.RemoveUserAsync(userToRemove);
                    return Ok();
                }
                return NotFound("Invalid user!!");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}