using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPKTWeb.Homes.Interface;
using SPKTWeb.Homes.Presenter;

namespace SPKTWeb.Homes
{
    public partial class Home : System.Web.UI.Page,IHome
    {
        HomePresenter _presenter;
        string queryString;
        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new HomePresenter();
            _presenter.Init(this);
        }

        protected void lbtnProfile_Click(object sender, EventArgs e)
        {
            _presenter.GotoAccountProfile();
        }

        public void DisplayCurrentAccount(SPKTCore.Core.Domain.Account account)
        {
            if (account != null)
            {
                lblXinChao.Text = "Xin chào: ";
                lbtnProfile.Visible = true;
                lbtnProfile.Text = account.UserName;
            }
            else
                lblXinChao.Text = "Chưa Đăng Nhập";
        }
    }
}