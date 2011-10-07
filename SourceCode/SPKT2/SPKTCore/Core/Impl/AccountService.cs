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
   public class AccountService:IAccountService
    {
        private IAccountRepository _accountRepository;
        private IPermissionRepository _permissionRepository;
        private IUserSession _userSession;
        private IRedirector _redirector;
        private IEmail _email;
        
        public AccountService()
        {
            //TODO: CẤP THIẾT hic hic
            //_accountRepository = ObjectFactory.GetInstance<IAccountRepository>();
            //_permissionRepository = ObjectFactory.GetInstance<IPermissionRepository>(); 
            //_userSession = ObjectFactory.GetInstance<IUserSession>();
            //_redirector = ObjectFactory.GetInstance<IRedirector>();
            //_email = ObjectFactory.GetInstance<IEmail>();
            _accountRepository = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            _permissionRepository = new SPKTCore.Core.DataAccess.Impl.PermissionRepository();
            _userSession = new UserSession();
            _redirector = new Redirector();
            _email = new Email();

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

        public string Login(string Username, string Password)
        {
            Password = Password.Encrypt(Username);
            Account account = _accountRepository.GetAccountByUsername(Username);

            //if there is only one account returned - good
            if (account != null)
            {
                //password matches
                if (account.Password == Password)
                {
                    if (account.EmailVerified)
                    {
                        _userSession.LoggedIn = true;
                        _userSession.Username = Username;
                        _userSession.CurrentUser = GetAccountByID(account.AccountID);
                        _redirector.GoToHomePage();
                    }
                    else
                    {
                        _email.SendEmailAddressVerificationEmail(account.UserName, account.Email);
                        return @"The login information you provided was correct 
                                but your email address has not yet been verified.  
                                We just sent another email verification email to you.  
                                Please follow the instructions in that email.";
                    }
                }
                else
                {
                    return "We were unable to log you in with that information!";
                }
            }

            return "We were unable to log you in with that information!";
        }


        public Account GetAccountByID(Int32 AccountID)
        {
            Account account = _accountRepository.GetAccountByID(AccountID);
            List<Permission> permissions = _permissionRepository.GetPermissionsByAccountID(AccountID);
            foreach (Permission permission in permissions)
            {
                account.AddPermission(permission);
            }

            return account;
        }
    }
}
