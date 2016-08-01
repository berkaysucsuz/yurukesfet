using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class device
    {
        public int id { get; set; }
        public int app_id { get; set; }
        public string token { get; set; }
        public string systemVersion { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string type { get; set; }




    }
}