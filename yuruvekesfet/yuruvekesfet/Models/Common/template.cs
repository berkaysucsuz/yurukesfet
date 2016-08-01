using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace yuruvekesfet.Models.Common
{
    public class template
    {
       [Range(11,11)]
        public int MyProperty { get; set; }


    }
}