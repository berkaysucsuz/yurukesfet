using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class feedback
    {
        public int id { get; set; }
       
        public string type { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updateAt { get; set; }
        public string fullName { get; set; }

        public string message { get; set; }
        public int account_id { get; set; }

    }
}