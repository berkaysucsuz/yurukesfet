using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.EventandCampaign
{
    public class @event
    {
        public int id { get; set; }
        public int campaign_id { get; set; }
        public int template_id { get; set; }
        public string kind { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updateAt { get; set; }
        public string type { get; set; }
        public string _text { get; set; }
        public int delay { get; set; }
        public int frequency { get; set; }
        public int maximum { get; set; }
    }
}