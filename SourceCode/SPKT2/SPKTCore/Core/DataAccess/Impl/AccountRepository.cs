﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using SPKTCore.Core.DataAccess.Impl;
using SPKTCore.Core;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.Domain;

/// <summary>
/// Summary description for AccountRepository
/// </summary>
namespace SPKTCore.Core.DataAccess.Impl
{
    [Pluggable("Default")]
    public class AccountRepository :IAccountRepository
    {
        private Connection conn;
        public AccountRepository()
        {
            conn = new Connection();

        }
        public Account GetAccountByID(int AccountID)
        {
            Account account = null;            
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                account = (from a in spktDC.Accounts
                           where a.AccountID == AccountID
                           select a).FirstOrDefault();

            }
            return account;
        }
        public Account GetAccountByEmail(string email)
        {
           Account account = null;
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                account = (from a in spktDC.Accounts
                           where a.Email == email
                           select a).FirstOrDefault();
              }
            return account;
        }
        public Account GetAccountByUsername(string Username)
        {
            Account account = null;
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                account = (from a in spktDC.Accounts
                           where a.UserName == Username
                           select a).FirstOrDefault();
            }
            return account;
        }
        public void SaveAccount(Account account)
        {
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                if (account.AccountID > 0)
                {
                    spktDC.Accounts.Attach(account, true);
                }
                else
                {
                    spktDC.Accounts.InsertOnSubmit(account);
                }
                spktDC.SubmitChanges();
            }
        }
        public void DeleteAccount(Account account)
        {
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                spktDC.Accounts.DeleteOnSubmit(account);
                spktDC.SubmitChanges();
            }
        }
        public void AddPermission(Account account, Permission permission)
        {
            using (SPKTDataContext spktDC = conn.GetContext())
            {
                AccountPermission ap = new AccountPermission();
                ap.AccountID = account.AccountID;
                ap.PermissionID = permission.PermissionID;
                spktDC.AccountPermissions.InsertOnSubmit(ap);
                spktDC.SubmitChanges();
            }

        }

        public List<Account> GetAllAccounts(int PageNumber)
        {
            throw new NotImplementedException();
        }

        public List<Account> SearchAccounts(string SearchText)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetApprovedAccountsByGroupID(int GroupID, int PageNumber)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAccountsToApproveByGroupID(int GroupID)
        {
            throw new NotImplementedException();
        }
    }
}