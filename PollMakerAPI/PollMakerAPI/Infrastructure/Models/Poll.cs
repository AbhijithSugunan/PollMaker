using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PollMakerAPI.Infrastructure.Models
{
    public class Poll
    {
        #region Properties

        [BsonId]
        public ObjectId Id { get; set; }
        
        public Guid PollId { get; set; }

        public Guid PollOwner { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }
        
        #endregion
    }
}
