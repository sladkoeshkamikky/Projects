using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.ModelBinding;
using System.IO;
using WebAppAutoServise.Class;

namespace WebAppAutoServise
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var auto = new Auto()
            {
                DateOfIssue = "",
                Run = "1000",
                CarOwner = "",
                CarBrand = ""
            };

            if (Page.IsPostBack)
            {
                // Получить данные из формы с помощью средств
                // привязки моделей ASP.NET
                IValueProvider provider =
                    new FormValueProvider(ModelBindingExecutionContext);
                

                    // В этой точке непосредственно начинается работа с Entity Framework

                    // Создать объект контекста
                    Contact context = new Contact();

                    // Вставить данные в таблицу с помощью LINQ+
                    context.car.Add(auto);

                    // Сохранить изменения в БД
                               
            }
         }
    }
}