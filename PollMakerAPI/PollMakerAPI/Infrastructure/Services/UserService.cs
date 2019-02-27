using PollMakerAPI.Infrastructure.Models;
using PollMakerAPI.Infrastructure.Repositories.Interfaces;
using PollMakerAPI.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task CreateUserAsync(User userToCreate)
        {
            try
            {
                // Need to Implement validation logic
                userToCreate.UserId = Guid.NewGuid();
                await _userRepository.CreateAsync(userToCreate);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUser(string email)
        {
            try
            {
                return _userRepository.GetUser(email);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task RemoveUserAsync(string email)
        {
            try
            {
                await _userRepository.RemoveUserAsync(email);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdatePassword(User user, string oldPassword, string newPassword)
        {
            try
            {
                if (user.Password == oldPassword && !string.IsNullOrWhiteSpace(newPassword))
                {
                    user.Password = newPassword;
                    await _userRepository.UpdateUserAsync(user);
                }
                else
                {
                    throw new ArgumentException("password validation error!!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
