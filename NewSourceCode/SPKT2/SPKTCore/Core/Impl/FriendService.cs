﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.Domain;
using SPKTCore.Core.DataAccess;
using StructureMap;

namespace SPKTCore.Core.Impl
{
    [Pluggable("Default")]
    public class FriendService : IFriendService
    {
        private IFriendInvitationRepository _friendInvitationRepository;
        private IFriendRepository _friendRepository;
        private IAccountRepository _accountRepository;
        private IWebContext _webContext;

        public FriendService()
        {
            _accountRepository = new SPKTCore.Core.DataAccess.Impl.AccountRepository();
            _webContext = new SPKTCore.Core.Impl.WebContext();
            _friendInvitationRepository = new SPKTCore.Core.DataAccess.Impl.FriendInvitationRepository();
            _friendRepository = new SPKTCore.Core.DataAccess.Impl.FriendRepository();
        }
        public bool IsFriend(Account account, Account accountBeingViewed)
        {
            if (account == null)
                return false;

            if (accountBeingViewed == null)
                return false;

            if (account.AccountID == accountBeingViewed.AccountID)
                return true;
            else
            {
                Friend friend = _friendRepository.GetFriendsByAccountID(accountBeingViewed.AccountID).Where(f => f.MyFriendAccountID == account.AccountID).FirstOrDefault();
                if (friend != null)
                    return true;
            }
            return false;
        }
        public void CreateFriendFromFriendInvitation(Guid InvitationKey, Account InvitationTo)
        {
            FriendInvitation friendInvitation = _friendInvitationRepository.GetFriendInvitationByGUID(InvitationKey);
            friendInvitation.BecameAccoutnID = InvitationTo.AccountID;
            _friendInvitationRepository.SaveFriendInvitation(friendInvitation);
            _friendInvitationRepository.CleanUpFriendInvitationsForThisEmail(friendInvitation);
            Friend friend = new Friend();
            friend.AccountID = friendInvitation.AccountID;
            friend.MyFriendAccountID = InvitationTo.AccountID;
            _friendRepository.SaveFriend(friend);
        }
        public int CountFriend(Account account)
        {
            List<Friend> l=_friendRepository.GetFriendsByAccountID(account.AccountID);
            int dem = l.Count();
            return dem;
        }
    }
}
