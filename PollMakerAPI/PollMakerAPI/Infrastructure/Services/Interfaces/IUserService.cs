using PollMakerAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUserAsync(User userToCreate);

        User GetUser(string email);

        Task RemoveUserAsync(User userToRemove);

        Task UpdatePassword(User user, string oldPassword, string newPassword);


    }
}
