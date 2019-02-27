using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PollMakerAPI.Infrastructure.Models
{
    public class Option
    {

        #region Properties

        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsSelected { get; set; }

        #endregion

    }
}
