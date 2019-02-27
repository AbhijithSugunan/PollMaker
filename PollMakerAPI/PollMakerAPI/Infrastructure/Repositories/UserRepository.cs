using MongoDB.Bson;
using MongoDB.Driver;
using PollMakerAPI.Infrastructure.Models;
using PollMakerAPI.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IPollContext _context;

        public UserRepository(IPollContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(User userToCreate)
        {
            try
            {
                await _context.Users.InsertOneAsync(userToCreate);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public User GetUser(string email)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq(x => x.Email, email);
                var user = _context.Users.Find(filter).FirstOrDefault();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> RemoveUserAsync(string email)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq(x => x.Email, email);
                var deleteResult = await _context.Users.DeleteOneAsync(filter);
                return (deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> UpdateUserAsync(User userToUpdate)
        {
            try
            {
                var updateResult = await _context.Users.ReplaceOneAsync(filter: x => x.Email == userToUpdate.Email, replacement: userToUpdate);
                return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
