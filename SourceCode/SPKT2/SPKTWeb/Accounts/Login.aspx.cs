﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPKTWeb.Accounts.Interface;
using SPKTWeb.Accounts.Presenter;


namespace SPKTWeb.Accounts
{

    public partial class Login : System.Web.UI.Page,ILogin
    {
        private LoginPresenter _Presenter;
        public HttpCookie cookie;// = new HttpCookie("Login");
        protected void Page_Load(object sender, EventArgs e)
        {
            _Presenter = new LoginPresenter();
            _Presenter.Init(this);            
        }

        public void DisplayMessage(string Message)
        {
            lblMessage.Text = Message;
        }

        protected void lbRecoverPassword_Click(object sender, EventArgs e)
        {
            _Presenter.GoToRecoverPassword();
        }
        
        protected void lbRegister_Click(object sender, EventArgs e)
        {
            _Presenter.GoToRegister();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {            
            _Presenter.Login(txtUserName.Text, txtPassword.Text,ckbAutoLogin.Checked);
            
        }
    }
}