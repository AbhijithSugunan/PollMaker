using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Models
{
    public class PollContent
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public Guid PollId { get; set; }

        public string PollQuestion { get; set; }

        public List<Option> Options { get; set; }
    }  
}
