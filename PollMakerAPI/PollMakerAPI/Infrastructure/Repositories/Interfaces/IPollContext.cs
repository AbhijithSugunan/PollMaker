using MongoDB.Driver;
using PollMakerAPI.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Repositories.Interfaces
{
    public interface IPollContext
    {
        IMongoCollection<User> Users { get; }
    }
}
