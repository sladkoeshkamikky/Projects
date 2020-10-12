using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    class Model
    {
        [Key]
        public int ModelId { get; set; }
        public string NameModel { get; set; }
    }
}