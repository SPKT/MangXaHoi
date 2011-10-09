using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTWeb.Accounts.Interface;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core;
using SPKTCore.Core.Impl;
using StructureMap;
using SPKTCore.Core.Domain;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTWeb.Accounts.Presenter
{
    public class RegisterPresenter
    {
        private IRegister _view;
        private IAccountRepository _accountRepository;
        private IPermissionRepository _permissionRepository;
        private IAccountService _accountService;
        private IWebContext _webContext;
        private IEmail _email;
        private IRedirector _redirector;

        public void Init(IRegister View)
        {
            _view = View;
            /*_accountRepository = ObjectFactory.GetInstance<IAccountRepository>();
            _permissionRepository = ObjectFactory.GetInstance<IPermissionRepository>();
             _accountService = ObjectFactory.GetInstance<IAccountService>();
            _webContext = ObjectFactory.GetInstance<IWebContext>();
            _email = ObjectFactory.GetInstance<IEmail>();*/
            _accountRepository = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            _permissionRepository = new SPKTCore.Core.DataAccess.Impl.PermissionRepository();
            _accountService = new AccountService();
            _webContext = new WebContext();
            _email = new Email();
            _redirector = new Redirector();
        }

        public void LoginLinkClicked()
        {
            IRedirector redirector = ObjectFactory.GetInstance<IRedirector>();
            redirector.GoToAccountLoginPage();
        }

        public void Register(string Username, string Password,string Email, EnumObject Object,
             string Captcha)
        {
                
                if (Captcha == _webContext.CaptchaImageText)
                {
                    SPKTCore.Core.Domain.Account a =
                        new SPKTCore.Core.Domain.Account();
                    a.Email = Email;
                    a.UserName = Username;
                    a.DisplayName = a.UserName;
                    a.CreateDate = DateTime.Now;
                    a.Password = Password.Encrypt(Username);
                   

                    if (_accountService.EmailInUse(Email))
                    {
                        _view.ShowErrorMessage("Mail đã được sử dụng");
                     }
                    else if (_accountService.UsernameInUse(Username))
                    {
                        _view.ShowErrorMessage("Tên đăng nhập này đã được sử dụng");
              
                    }
                    else
                    {
                        _accountRepository.SaveAccount(a);
                        Permission publicPermission = _permissionRepository.GetPermissionByName(Object.ToString());
                        Permission registeredPermission = _permissionRepository.GetPermissionByName("Registered");
                        SPKTCore.Core.Domain.Account newAccount = _accountRepository.GetAccountByUsername(Username);

                        _accountRepository.AddPermission(newAccount, publicPermission);
                        _accountRepository.AddPermission(newAccount, registeredPermission);


                        _email.SendEmailAddressVerificationEmail(a.UserName, a.Email);
                        _redirector.GoToAccountLoginPage();
                    }
                }
                else
                {
                    _view.ShowErrorMessage("CAPTCHA bạn nhập không đúng! Vui lòng nhập lại");
                }

        }
    }
}