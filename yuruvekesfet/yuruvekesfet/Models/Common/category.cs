using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class category
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string displayName { get; set; }
    
    }
}