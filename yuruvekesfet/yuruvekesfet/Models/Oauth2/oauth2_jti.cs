using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Oauth2
{
    public class oauth2_jti
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public string subject { get; set; }
        public string audience { get; set; }
        public DateTime expires { get; set; }
        public string jti { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}