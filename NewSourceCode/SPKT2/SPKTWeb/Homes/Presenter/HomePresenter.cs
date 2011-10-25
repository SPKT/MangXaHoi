using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTCore.Core;
using SPKTCore.Core.Impl;
using SPKTWeb.Homes.Interface;
using SPKTCore.Core.Domain;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTWeb.Homes.Presenter
{
    public class HomePresenter
    {
        IUserSession _userSession;
        IHome _view;
        IAccountService _accountService;
        IRedirector _redirector;
        Account account;
        IProfileService _profileService;
        Profile profile;
        public HomePresenter()
        {
            _userSession = new UserSession();
            _accountService=new AccountService();
            _redirector = new Redirector();
            _profileService = new ProfileService();
        }
        public void Init(IHome View)
        {
            _view = View;
            
            if(_userSession.LoggedIn==true)
            {
                account=_userSession.CurrentUser;

            }
            else
                account=null;
            _view.DisplayCurrentAccount(account);

        }
        public void GotoAccountProfile()
        {
            profile=_profileService.LoadProfileByAccountID(account.AccountID);
            if (profile != null)
            {
                _redirector.Redirect("~/Profiles/UserProfile.aspx");

            }
            else
                _redirector.Redirect("~/Profiles/ManageProfile.aspx");
        }

    }
}