using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTCore.Core;
using SPKTCore.Core.Impl;
using SPKTWeb.Profiles.Interface;
using SPKTCore.Core.Domain;

namespace SPKTWeb.Profiles.Presenter
{
    
    public class UserProfilePresenter
    {
        IAlertService _alertService;
        IProfileService _profileService;
        IUserProfile _view;
        IUserSession _userSession;
        IWebContext _webContext;
        IAccountService _accountService;
        public UserProfilePresenter()
        {
            _alertService = new AlertService();
            _profileService = new ProfileService();
            _userSession = new UserSession();
            _webContext = new WebContext();
            _accountService = new AccountService();
        }
        public void Init(IUserProfile view,bool IsPostBack)
        {
            _view = view;
            if (!IsPostBack)
            {
                string profileID=_webContext.GetQueryStringValue("ProfileID");
                List<Alert> listAlert = new List<Alert>();
                    if (_userSession.LoggedIn)
                    {
                         if (profileID != null)
                         {
                             int proID = int.Parse(profileID);
                             Profile profile = _profileService.GetProfileByProfileID(proID);
                             if (profile != null)
                             {
                                 if (_userSession.CurrentUser.AccountID == profile.AccountID)
                                 {
                                     LoadAlertUserProfile(listAlert, _userSession.CurrentUser.AccountID);
                                 }
                                 else
                                     LoadAlert(listAlert, profile.AccountID);
                             }
                             else
                                 _view.Message("Không có Profile này");
                         }
                         else
                         {
                             LoadAlertUserProfile(listAlert,_userSession.CurrentUser.AccountID);
                         }
                    }
                    else
                    {
                        _view.Message("chua dang nhap");
                    }
            }
       }
        public void LoadAlertUserProfile(List<Alert> listAlert, Int32 accountID)
        {
            listAlert = _alertService.GetAlertsByAccountID(accountID);
            _view.LoadAlertUserProfile(listAlert);
        }
        public void LoadAlert(List<Alert> listAlert, Int32 accountID)
        {
            listAlert = _alertService.GetAlertsByAccountID(accountID);
            _view.LoadAlert(listAlert);
        }
        

    }
}