using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Oauth2
{
    public class oauth2_public_key
    {
        public int id { get; set; }
        public int client_id { get; set; }
        public string publicKey { get; set; }
        public string privateKey { get; set; }
        public string encryptionAlgorithm { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}