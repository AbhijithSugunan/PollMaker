using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PollMakerAPI.Infrastructure.Configurations;
using PollMakerAPI.Infrastructure.Models;
using PollMakerAPI.Infrastructure.Repositories.Interfaces;

namespace PollMakerAPI.Infrastructure.Repositories
{
    public class PollContext : IPollContext
    {
        private readonly IMongoDatabase _db;

        public PollContext(IOptions<MongoConfiguration> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
            
        }

        public IMongoCollection<User> Users => _db.GetCollection<User>("Users");
        public IMongoCollection<Poll> Polls => _db.GetCollection<Poll>("Polls");
        public IMongoCollection<PollContent> PollContents => _db.GetCollection<PollContent>("PollContents");
    }
}
