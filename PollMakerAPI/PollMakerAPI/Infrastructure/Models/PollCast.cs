using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Models
{
    public class PollCast
    {
        #region Properties

        [BsonId]
        public ObjectId Id { get; set; }

        public Guid UserId { get; set; }

        public Guid PollId { get; set; }

        public int OptionId { get; set; }

        #endregion
    }
}
