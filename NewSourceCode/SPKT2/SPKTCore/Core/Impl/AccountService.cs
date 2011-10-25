﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.Domain;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTCore.Core.Impl
{
    [Pluggable("Default")]
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;
        private IPermissionRepository _permissionRepository;
        private IUserSession _userSession;
        private IRedirector _redirector;
        private IEmail _email;
        private IProfileService _profileService;
        private IWebContext _webContext;
        private IFriendService _friendService;
        private FriendInvitation friendInvitation;
        public AccountService()
        {
            _accountRepository = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            _permissionRepository = new SPKTCore.Core.DataAccess.Impl.PermissionRepository();
            _userSession = new UserSession();
            _redirector = new Redirector();
            _email = new Email();
            _profileService = new ProfileService();
            _webContext=new SPKTCore.Core.Impl.WebContext();
            _friendService = new SPKTCore.Core.Impl.FriendService();
            friendInvitation = new FriendInvitation();
        }

        public bool UsernameInUse(string Username)
        {
            Account account = _accountRepository.GetAccountByUsername(Username);
            if (account != null)
                return true;

            return false;
        }

        public bool EmailInUse(string Email)
        {
            Account account = _accountRepository.GetAccountByEmail(Email);
            if (account != null)
                return true;

            return false;
        }

        public void Logout()
        {
            _userSession.LoggedIn = false;
            _userSession.CurrentUser = null;
            _userSession.Username = "";
            _redirector.GoToAccountLoginPage();
        }
        public void Register(Account a, string permission)
        {
            _accountRepository.SaveAccount(a);
            Permission publicPermission = _permissionRepository.GetPermissionByName(permission);
            Permission registeredPermission = _permissionRepository.GetPermissionByName("Registered");
            Account newAccount = _accountRepository.GetAccountByUsername(a.UserName);
            if (friendInvitation != null)
            {
                _friendService.CreateFriendFromFriendInvitation(new Guid(_webContext.FriendshipRequest), newAccount);
            }
            _accountRepository.AddPermission(newAccount, publicPermission);
            _accountRepository.AddPermission(newAccount, registeredPermission);
            _email.SendEmailAddressVerificationEmail(a.UserName, a.Email);
        }
        public bool Login(string Username, string Password, bool rememberMe, out String returnMessage)
        {
            if (rememberMe == false)
                return Login(Username, Password,out returnMessage);
            IWebContext webContext = new WebContext();
            webContext.SaveLoginInfoToCookie(Username, Password);
            return Login(Username, Password, out returnMessage); 
        }
        public bool Login(string Username, string Password)
        {
            String message;
            return Login(Username, Password,out message );
        }
        public bool Login(string Username, string Password,out String returnMessage)
        {
            Password = Password.Encrypt(Username);
            Account account = _accountRepository.GetAccountByUsername(Username);

            if (account != null)
            {
                
                if (account.Password == Password)
                {
                    if (account.EmailVerified)
                    {
                        _userSession.LoggedIn = true;
                        _userSession.Username = Username;
                        _userSession.CurrentUser = GetAccountByID(account.AccountID);
                        returnMessage = "Đăng nhập thành công";
                        if (!string.IsNullOrEmpty(_webContext.FriendshipRequest))
                        {
                            _friendService.CreateFriendFromFriendInvitation(new Guid(_webContext.FriendshipRequest), _userSession.CurrentUser);
                        }
                        return true;
                    }
                    else
                    {
                        
                        returnMessage= @"Bạn chưa xác thực email";
                        return false;
                    }
                }
                else
                {
                    returnMessage= "Tên đăng nhập hoặc mật khẩu không đúng";
                    return false;
                }
            }

            returnMessage = "We were unable to log you in with that information!";
            return false;
        }        

        public Account GetAccountByID(Int32 AccountID)
        {
            Account account = _accountRepository.GetAccountByID(AccountID);
            //TODO:danh cho profile
            Profile profile = _profileService.LoadProfileByAccountID(AccountID);
            if (profile != null)
            {
                account.Profile = profile;
            }
            List<Permission> permissions = _permissionRepository.GetPermissionsByAccountID(AccountID);
            foreach (Permission permission in permissions)
            {
                account.AddPermission(permission);
            }

            return account;
        }

    }
}