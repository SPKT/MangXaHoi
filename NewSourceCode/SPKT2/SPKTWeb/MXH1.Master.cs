using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPKTCore.Core.Impl;

namespace MXH
{
    public partial class MXH1 : System.Web.UI.MasterPage
    {
        Redirector _redirector;
        protected void Page_Load(object sender, EventArgs e)
        {
            _redirector = new Redirector();
        }

        protected void bt_TimKiem_Click(object sender, EventArgs e)
        {
            
            _redirector.GotoSearch(asbCity.Text);
        }
        protected void lbt_DangNhap_Click(object sender, EventArgs e)
        {
            _redirector.GoToAccountLoginPage();
        }
        protected void lbt_DangKy_Click(object sender, EventArgs e)
        {
            _redirector.GoToAccountRegisterPage();
        }
    }
}