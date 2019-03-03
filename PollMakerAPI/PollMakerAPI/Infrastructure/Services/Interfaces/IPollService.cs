using PollMakerAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Services.Interfaces
{
    public interface IPollService
    {
        Task CreateNewPoll(PollCreationRequest request);

        Task CastPoll(Guid userId, Guid pollId, int optionId);
    }
}
