using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class activity
    {
        public int id { get; set; }
        public string verb { get; set; }
        public DateTime occurredAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int actorUser_id { get; set; }
        public int actorDevice_id { get; set; }
        public int objectBeacon_id { get; set; }
        public int objectEvent_id { get; set; }



    
    
    }
}