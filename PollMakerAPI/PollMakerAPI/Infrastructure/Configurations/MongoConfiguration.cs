using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Configurations
{
    public class MongoConfiguration
    {
        #region Properties

        public string ConnectionString { get; set; }

        public string Database { get; set; }

        #endregion
    }
}
