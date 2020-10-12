using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    public class Car_Owner
    {
        [Key]
        public int Car_OnerId { get; set; }
        public string LastNameV { get; set; } // Фамилия владельца
        public string NameV { get; set; } //Имя владельца
        public string FirstNameV { get; set; } //Отчество владельца

        public virtual ICollection<Auto> Auto { get; set; }
        public virtual ICollection<Repair> repair {get; set;}
    }
}