using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SPKTWeb.Accounts.Interface;
using SPKTWeb.Accounts;
using SPKTWeb.Accounts.Presenter;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTWeb.Accounts
{
    public partial class Register : System.Web.UI.Page,IRegister
    {
        RegisterPresenter _Presenter;
        EnumObject DoiTuong = new EnumObject();
        protected void Page_Load(object sender, EventArgs e)
        {
            _Presenter=new RegisterPresenter();
            _Presenter.Init(this);
            if (rdbCuuSinhVien.Checked == true)
                DoiTuong = EnumObject.User;
            else if (rdbGiaoVien.Checked == true)
                DoiTuong = EnumObject.User;
            else if (rdbNguoiNgoai.Checked == true)
                DoiTuong = EnumObject.OutUser;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string passWord=txtPassword.Text;
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            String captCha = txtCaptCha.Text;
            _Presenter.Register(userName, passWord, email, DoiTuong,captCha);
           
        }

        public void ShowErrorMessage(string Message)
        {
            lblErrorMessage.Text = Message;
        }





        public void LoadEmailAddressFromFriendInvitation(string Email)
        {
            throw new NotImplementedException();
        }


  }
}