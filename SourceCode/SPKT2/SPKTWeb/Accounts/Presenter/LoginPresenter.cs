using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using SPKTWeb.Accounts.Interface;
using SPKTCore.Core;


namespace SPKTWeb.Accounts.Presenter
{
    public class LoginPresenter
    {
        private ILogin _view;
        private IAccountService _accountService;
        private IRedirector _redirector;
        private IWebContext _webContext;

        public void Init(ILogin view)
        {
            _view = view;
            //_accountService = ObjectFactory.GetInstance<IAccountService>();
           //_redirector = ObjectFactory.GetInstance<IRedirector>();
           //_webContext = ObjectFactory.GetInstance<IWebContext>();
            _accountService = new SPKTCore.Core.Impl.AccountService();
            _redirector = new SPKTCore.Core.Impl.Redirector();
            _webContext = new SPKTCore.Core.Impl.WebContext();
       }

        public void Login(string username, string password)
        {
            string message = _accountService.Login(username, password);
            _view.DisplayMessage(message);
        }

        public void GoToRegister()
        {
            _redirector.GoToAccountRegisterPage();
        }

        public void GoToRecoverPassword()
        {
            _redirector.GoToAccountRecoverPasswordPage();
        }
    }
}
