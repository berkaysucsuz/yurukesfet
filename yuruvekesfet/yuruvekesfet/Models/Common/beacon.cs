using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class beacon
    {
        public int account_id { get; set; }
        public string status { get; set; }
        public string displayName { get; set; }
        public int major { get; set; }

        public int minor { get; set; }
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string uuid { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int category_id { get; set; }



    }
}