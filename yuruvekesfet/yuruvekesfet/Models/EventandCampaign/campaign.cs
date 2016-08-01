using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.EventandCampaign
{
    public class campaign
    {
        public int id { get; set; }
        public int account_id {get; set;}
        public string displayName { get; set; }
        public DateTime startAt { get; set; }
        public DateTime endAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updateAt { get; set; }
}
}