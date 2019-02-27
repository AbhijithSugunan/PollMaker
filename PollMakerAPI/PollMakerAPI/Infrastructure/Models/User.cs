using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Models
{
    public class User
    {
        #region Properties

        [BsonId]
        public ObjectId Id { get; set; }

        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string phoneno { get; set; }

        #endregion
    }
}
