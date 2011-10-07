using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTWeb.Accounts.Interface;
using SPKTCore.Core;
using SPKTCore.Core.DataAccess;
using StructureMap;
using SPKTCore.Core.Impl;
using SPKTCore.Core.Domain;

namespace SPKTWeb.Accounts.Presenter
{
    public class EditAccountPresenter
    {
        private IEditAccount _view;
        private IUserSession _userSession;
        private IAccountService _accountService;
        private IAccountRepository _accountRepository;
        private Account account;
        private IRedirector _redirector;
        private IEmail _email;

        public EditAccountPresenter()
        {
           /* _userSession = ObjectFactory.GetInstance<IUserSession>();
            _accountRepository = ObjectFactory.GetInstance<IAccountRepository>();
            _redirector = ObjectFactory.GetInstance<IRedirector>();
            _accountService = ObjectFactory.GetInstance<IAccountService>();
            _email = ObjectFactory.GetInstance<IEmail>();*/
            _userSession = new UserSession();
            _accountRepository = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            _redirector = new Redirector();
            _accountService = new AccountService();
            _email = new Email();       
        }

        public void Init(IEditAccount View, bool IsPostBack)
        {
            _view = View;

            if (_userSession.CurrentUser != null)
                account = _userSession.CurrentUser;
            else 
                _redirector.GoToAccountLoginPage();

            if(!IsPostBack)
                LoadCurrentUser();
        }

        private void LoadCurrentUser()
        {
            _view.LoadCurrentInformation(_userSession.CurrentUser);
        }

        public void UpdateAccount(string OldPassword, string NewPassword, string Username,string DisplayName,string Email )
        {
            //verify that this user is the same as the logged in user
            if(OldPassword.Encrypt(Username) == account.Password)
            {
                if (Email != _userSession.CurrentUser.Email)
                {
                    if (!_accountService.EmailInUse(Email))
                    {
                        account.Email = Email;
                        account.EmailVerified = false;
                        _email.SendEmailAddressVerificationEmail(account.UserName, Email);                        
                    }
                    else
                    {
                        _view.ShowMessage("The email your entered is already in our system!");
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(NewPassword))
               
                   account.Password = NewPassword.Encrypt(Username);

                account.DisplayName = DisplayName;
                _accountRepository.SaveAccount(account);
                _view.ShowMessage("Your account has been updated!");
            }
            else
            {
                _view.ShowMessage("The password you entered doesn't match your current password!  Please try again.");
            }
        }
    }
}