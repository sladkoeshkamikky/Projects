using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    public class Master
    {
        [Key]
        public int MasterId { get; set; }
        public string LastNameM { get; set; } // Фамилия мастера
        public string NameM { get; set; } //Имя мастера
        public string FirstNameM { get; set; } //Отчество мастера

        public virtual ICollection<Repair> repair { get; set; }
    }
}