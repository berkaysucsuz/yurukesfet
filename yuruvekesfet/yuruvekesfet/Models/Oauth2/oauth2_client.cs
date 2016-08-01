using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Oauth2
{
    public class oauth2_client
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string clientId { get; set; }
        public string secret { get; set; }
        public string redirectUri { get; set; }
        public string grantType { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}