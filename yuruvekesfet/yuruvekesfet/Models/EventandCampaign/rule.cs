using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.EventandCampaign
{
    public class rule
    {
        public int id { get; set; }
        public int event_id { get; set; }
        public string kind { get; set; }
        public string executeOn { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string type { get; set; }

    }
}