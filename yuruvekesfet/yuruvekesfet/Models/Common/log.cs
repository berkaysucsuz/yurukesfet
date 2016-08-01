using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class log
    {


        public int id { get; set; }

        public int user_id { get; set; }
        public int account_id { get; set; }
        public string type { get; set; }
        public string remoteAddress { get; set; }
        public DateTime createdAt { get; set; }




    }
}