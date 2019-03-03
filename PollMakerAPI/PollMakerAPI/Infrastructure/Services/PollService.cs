
using PollMakerAPI.Infrastructure.Exceptions;
using PollMakerAPI.Infrastructure.Models;
using PollMakerAPI.Infrastructure.Repositories.Interfaces;
using PollMakerAPI.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Services
{
    public class PollService : IPollService
    {

        private readonly IPollRepository _pollRepository;

        public PollService(IPollRepository pollRepo)
        {
            _pollRepository = pollRepo;
        }
        
        public async Task CreateNewPoll(PollCreationRequest request)
        {
            try
            {
                if (request.StartsAt < DateTime.UtcNow)
                {
                    throw new InvalidPollException("Start time expired");
                }

                var pollObj = new Poll()
                {
                    PollId = Guid.NewGuid(),
                    PollOwner = request.PollOwner,
                    CreatedAt = DateTime.UtcNow,
                    StartAt = request.StartsAt,
                    EndAt = request.EndsAt
                };

                var pollContentObj = new PollContent()
                {
                    PollId = pollObj.PollId,
                    PollQuestion = request.PollQuestion,
                    Options = request.Options
                };

                await _pollRepository.CreatePollAsync(pollObj);
                await _pollRepository.CreatePollContentAsync(pollContentObj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task CastPoll(Guid userId, Guid pollId, int optionId)
        {
            throw new NotImplementedException();
        }
    }
}
