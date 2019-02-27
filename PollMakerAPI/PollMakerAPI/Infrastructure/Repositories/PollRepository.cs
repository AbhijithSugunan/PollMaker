using PollMakerAPI.Infrastructure.Models;
using PollMakerAPI.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Repositories
{
    public class PollRepository : IPollRepository
    {
        private readonly IPollContext _context;

        public PollRepository(IPollContext context)
        {
            _context = context;
        }

        public async Task CreatePollAsync(Poll pollToCreate)
        {
            try
            {
                await _context.Polls.InsertOneAsync(pollToCreate);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task CreatePollContentAsync(PollContent pollContent)
        {
            try
            {
                await _context.PollContents.InsertOneAsync(pollContent);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
