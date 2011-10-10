using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using StructureMap;
using SPKTCore.Core;

namespace SPKTCore.Core.Impl
{
    [Pluggable("Default")]
    public class Redirector : IRedirector
    {

        public void GoToAccountAccessDenied()
        {
            Redirect("~/Accounts/AccessDenied.aspx");

        }

        public void GoToAccountRecoverPasswordPage()
        {
            Redirect("~/Accounts/RecoverPassword.aspx");
        }

        public void GoToAccountEditAccountPage()
        {
            Redirect("~/Accounts/EditAccount.aspx");
        }

        public void GoToAccountLoginPage()
        {
            Redirect("~/Accounts/Login.aspx");
        }

        public void GoToAccountRegisterPage()
        {
            Redirect("~/Accounts/Register.aspx");
        }

        public void GoToHomePage()
        {
            Redirect("~/Default.aspx");
        }

        public void GoToErrorPage()
        {
            Redirect("~/Error.aspx");
        }

        public void Redirect(string path)
        {
            HttpContext.Current.Response.Redirect(path);
        }

        public void GotoHomePage()
        {
            throw new NotImplementedException();
        }

    }
}