using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Models
{
    public class PollCreationRequest
    {
        #region Properties

        public Guid PollOwner { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }

        public string PollQuestion { get; set; }

        public List<Option> Options { get; set; }

        #endregion
    }
}
