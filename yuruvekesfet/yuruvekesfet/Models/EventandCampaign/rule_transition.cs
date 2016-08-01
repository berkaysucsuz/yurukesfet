using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.EventandCampaign
{
    public class rule_transition
    {
        public int id { get; set; }
        public int rule_id { get; set; }
        public string type { get; set; }
        public int area_id { get; set; }
    }
}