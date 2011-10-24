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
        private IAccountService _accountService;
        private IWebContext _webContext;
        private IEmail _email;
        private IRedirector _redirector;
        private IParameterIntService _parameterIntService;
        public RegisterPresenter()
        {
            _accountService = new AccountService();
            _webContext = new WebContext();
            _email = new Email();
            _redirector = new Redirector();
            _parameterIntService = new ParameterIntService();
        }
        public void Init(IRegister View)
        {
            _view = View;

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
                    string permission = Object.ToString();
                    _accountService.Register(a, permission);
                    _redirector.GoToAccountLoginPage();
                }
            }
            else
            {
                _view.ShowErrorMessage("CAPTCHA bạn nhập không đúng! Vui lòng nhập lại");
            }

        }

        public bool CheckUserName(string username)
        {
            if (_accountService.UsernameInUse(username))
            {
                _view.LoadMessageCheckUserName("Tên đăng ký đã tồn tại");
                return false;
            }
            else
            {
                _view.LoadMessageCheckUserName("");
                return true;
            }
        }

        public bool CheckPassword(string PasswordPre, string Password)
        {
            if (PasswordPre == Password)
            {
                _view.LoadMessagePassWord("");
                return true;
            }
            else
            {
                _view.LoadMessagePassWord("Hai mật khẩu không giống nhau");
                return false;
            }

        }

        public bool CheckPasswordLength(string password)
        {
            int dkmin = _parameterIntService.GetParameterIntByName("PasswordMin");
            int dkmax = _parameterIntService.GetParameterIntByName("PasswordMax");
            if (password.Length < dkmin)
            {
                _view.LoadMessagePassWordLength("Mật khẩu bảo mật quá yếu");
                return false;
            }
            else if (password.Length > dkmax)
            {
                _view.LoadMessagePassWordLength("Mật khẩu quá dài");
                return false;
            }
            else
            {
                _view.LoadMessagePassWordLength("");
                return true;
            }
            
        }
    }
}