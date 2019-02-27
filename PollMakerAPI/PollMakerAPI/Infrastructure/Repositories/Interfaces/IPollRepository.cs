using PollMakerAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Repositories.Interfaces
{
    public interface IPollRepository
    {
        Task CreatePollAsync(Poll pollToCreate);

        Task CreatePollContentAsync(PollContent pollContent);
    }
}
