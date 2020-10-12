using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    public class Auto
    {
        [Key]
        public int AutoId { get; set; }
        public string DateOfIssue { get; set; } //Дата выпуска
        public string Run { get; set; } //Пробег
        public string CarOwner { get; set; }//Владелец 
        public string CarBrand { get; set; } //Марка авто

        public virtual ICollection<Car_Brand> car_brand { get; set; }
        public virtual ICollection<Car_Owner> car_owner { get; set; }
    }

    

}