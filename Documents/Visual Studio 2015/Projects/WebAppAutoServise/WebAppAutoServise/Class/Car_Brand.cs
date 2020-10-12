using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAutoServise.Class
{
    public class Car_Brand
    {
        public virtual Auto auto { get; set; }
        public string Brand()
        {
            List<string> list = new List<string>();
            list.Add("Henday");
            list.Add("Mazda");
            list.Add("Honda");
            list.Add("Opel");
            list.Add("Boshe");
            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            return "";
        }


    }
}