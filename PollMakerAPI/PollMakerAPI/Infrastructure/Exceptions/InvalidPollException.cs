using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Exceptions
{
    public class InvalidPollException : Exception
    {
        public InvalidPollException()
        {
        }

        public InvalidPollException(string message)
            : base(message)
        {
        }

        public InvalidPollException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
