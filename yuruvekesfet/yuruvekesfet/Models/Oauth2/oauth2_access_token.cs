using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Oauth2
{
    public class oauth2_access_token
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public int user_id { get; set; }
        public string accessToken { get; set; }
        public DateTime expires { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}