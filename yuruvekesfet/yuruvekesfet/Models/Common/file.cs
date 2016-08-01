using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class file
    {

        [Range(11,11)]
        public int id { get; set; }
        public string filename { get; set; }
        public string options { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string type { get; set; }
        public int account_id { get; set; }






    }
}