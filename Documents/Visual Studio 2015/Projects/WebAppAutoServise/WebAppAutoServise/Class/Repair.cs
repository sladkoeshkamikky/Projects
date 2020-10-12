using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    public class Repair
    {
        [Key]
        public int RepairId { get; set; }
        public string DateCreate { get; set; }  //дата создания
        public string CarOwner { get; set; }    //Владелец
        public string Master { get; set; }      //Мастер
        public string Reason { get; set; }      //Причина
        public string СurrentStatus { get; set; } //Тукущий статус
        public string ResultRepair { get; set; }    //Результат

        public virtual ICollection<Car_Owner> car_owner { get; set; }
        public virtual ICollection<Master> master { get; set; }
    }
}
