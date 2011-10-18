using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTCore.Core;
using SPKTCore.Core.DataAccess;
using SPKTWeb.Accounts.Interface;
using StructureMap;
using SPKTCore.Core.Impl;
using SPKTCore.Core.Domain;

namespace SPKTWeb.Accounts.Presenter
{
    public class VerifyEmailPresenter
    {
        private IWebContext _webContext;
        private IAccountRepository _accountRepository;
        public void Init(IVerifyEmail _view)
        {
           /* _webContext = ObjectFactory.GetInstance<IWebContext>();
            _accountRepository = ObjectFactory.GetInstance<IAccountRepository>();*/
            _webContext = new WebContext();
            _accountRepository = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            string username = Cryptography.Decrypt(_webContext.UsernameToVerify,ParameterSetting.EmailVerificationEncryptKey);

            Account account = _accountRepository.GetAccountByUsername(username);

            if (account != null)
            {
                account.EmailVerified = true;
                _accountRepository.SaveAccount(account);
                _view.ShowMessage("Your email address has been successfully verified!");
                
            }
            else
            {
                _view.ShowMessage("There appears to be something wrong with your verification link!  Please try again.  If you are having issues by clicking on the link, please try copying the URL from your email and pasting it into your browser window.");
            }
        }
    }
}