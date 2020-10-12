using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppAutoServise.Class;

namespace WebAppAutoServise
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            
        }
        public virtual List<Auto> car { get; set; }
    }
}