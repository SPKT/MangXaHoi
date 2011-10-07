using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace SPKTWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Username_Changed(object sender, EventArgs e)
        {
            CustomMembershipProvider cus = new CustomMembershipProvider();
            
            if (cus.GetUser(Username.Text,true) != null)
            {
                Response.Write("da ton tai");
                UserAvailability.InnerText = "Username taken, sorry.";
                UserAvailability.Attributes.Add("class", "taken");
            }
            else
            {
                UserAvailability.InnerText = "Username available!";
                UserAvailability.Attributes.Add("class", "available");
            }

        }
    }
}