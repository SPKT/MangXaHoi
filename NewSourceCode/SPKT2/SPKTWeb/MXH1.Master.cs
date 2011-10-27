using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPKTCore.Core.Impl;
using SPKTWeb.Interface;
using SPKTWeb.Presenter;
using SPKTCore.Core;

namespace MXH
{
    public partial class MXH1 : System.Web.UI.MasterPage, IMXH1Master
    {
        IRedirector _redirector;
        MXH1MasterPresenter _presenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            _redirector = new Redirector();
<<<<<<< HEAD
=======
            _presenter = new MXH1MasterPresenter();
            _presenter.Init(this);
>>>>>>> 74349b0b329f92be16c92eafca08b233a2499789
        }

        protected void bt_TimKiem_Click(object sender, EventArgs e)
        {
            
            _redirector.GotoSearch(asbCity.Text);
        }
<<<<<<< HEAD
        protected void lbt_DangNhap_Click(object sender, EventArgs e)
        {
            _redirector.GoToAccountLoginPage();
        }
        protected void lbt_DangKy_Click(object sender, EventArgs e)
        {
            _redirector.GoToAccountRegisterPage();
=======

        public void ShowUserName(string userName)
        {
            if (userName == "")
                lblUserName.Text = "Khách";
            lblUserName.Text = "Xin chào " + userName.ToUpper() ;
>>>>>>> 74349b0b329f92be16c92eafca08b233a2499789
        }
    }
}