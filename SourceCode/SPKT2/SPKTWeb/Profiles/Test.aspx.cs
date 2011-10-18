using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SPKTWeb.Profiles
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            panCha.ID = "pan2";
            Button btn = new Button();
            btn.Text = "Hello";
            panCha.Controls.Add(btn);
            
        }
    }
}