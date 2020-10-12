using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    public class Status_History     //История ремонта
    {
        [Key]
        public int Status_HistoryId { get; set; }
        public string Incident { get; set; } // Случай
        public string DateCreate { get; set; } //Дата создания
        public string Status { get; set; }  //Статус
        public string Result { get; set; }  //Результат
    }
}