using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using StructureMap;

namespace SPKTCore.Core.Impl
{
     [Pluggable("Default")]
    public class Redirector: IRedirector
    {

        public void GoToAccountAccessDenied()
        {
            Redirect("~/Account/AccessDenied.aspx");
            
        }
         
        public void GoToAccountRecoverPasswordPage()
        {
            Redirect("~/Account/RecoverPassword.aspx");
        }

        public void GoToAccountEditAccountPage()
        {
            Redirect("~/Account/EditAccount.aspx");
        }

         public void GoToAccountLoginPage()
        {
            Redirect("~/Account/Login.aspx");
        }

        public void GoToAccountRegisterPage()
        {
            Redirect("~/Account/Register.aspx");
        }

        public void GoToHomePage()
        {
            Redirect("~/Default.aspx");
        }

        public void GoToErrorPage()
        {
            Redirect("~/Error.aspx");
        }

        private void Redirect(string path)
        {
            HttpContext.Current.Response.Redirect(path);
        }

        public void GotoHomePage()
        {
            throw new NotImplementedException();
        }

        void IRedirector.Redirect(string path)
        {
            throw new NotImplementedException();
        }
    }
}
