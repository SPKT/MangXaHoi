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
    public partial class EditAccount : System.Web.UI.Page,IEditAccount
    {
        EditAccountPresenter _presenter;
        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new EditAccountPresenter();
            _presenter.Init(this,IsPostBack);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.UpdateAccount(txtOldPassword.Text, txtNewPassword2.Text, lblUserName.Text, txtDisplayName.Text,txtEmail.Text);
        }

        public void ShowMessage(string Message)
        {
            lblErrorMessage.Text = Message;
        }

        public void LoadCurrentInformation(SPKTCore.Core.Domain.Account account)
        {
            lblUserName.Text = account.UserName;
            txtDisplayName.Text = account.UserName;
            txtEmail.Text = account.Email;
         }
    }
}