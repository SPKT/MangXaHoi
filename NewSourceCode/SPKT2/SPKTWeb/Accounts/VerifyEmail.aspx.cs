using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPKTWeb.Accounts.Presenter;
using SPKTWeb.Accounts.Interface;

namespace SPKTWeb.Accounts
{
    public partial class VerifyEmail : System.Web.UI.Page, IVerifyEmail
    {
        VerifyEmailPresenter _presenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new VerifyEmailPresenter();
            _presenter.Init(this);
        }

        public void ShowMessage(string Message)
        {
            lblMessage.Text = Message;

        }
    }
}