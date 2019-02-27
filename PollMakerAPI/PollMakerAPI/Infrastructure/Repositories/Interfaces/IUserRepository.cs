using PollMakerAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task CreateAsync(User userToCreate);

        User GetUser(string email);

        Task<bool> UpdateUserAsync(User userToUpdate);

        Task<bool> RemoveUserAsync(string email);
    }
}
