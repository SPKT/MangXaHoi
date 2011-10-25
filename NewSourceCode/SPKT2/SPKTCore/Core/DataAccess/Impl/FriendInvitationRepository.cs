using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.DataAccess.Impl;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core.DataAccess.Impl
{
    [Pluggable("Default")]
    public class FriendInvitationRepository : IFriendInvitationRepository
    {
        private Connection conn;
        public FriendInvitationRepository()
        {
            conn = new Connection();
        }

        public List<FriendInvitation> GetFriendInvitationsByAccountID(Int32 AccountID)
        {
            List<FriendInvitation> result = new List<FriendInvitation>();
            using (SPKTDataContext dc = conn.GetContext())
            {
                IEnumerable<FriendInvitation> friendInvitations = dc.FriendInvitations.Where(fi => fi.AccountID == AccountID);
                result = friendInvitations.ToList();
            }
            return result;
        }

        public FriendInvitation GetFriendInvitationByGUID(Guid guid)
        {
            FriendInvitation friendInvitation;
            using (SPKTDataContext dc = conn.GetContext())
            {
                friendInvitation = dc.FriendInvitations.Where(fi => fi.GUID == guid).FirstOrDefault();
            }
            return friendInvitation;
        }
        public void SaveFriendInvitation(FriendInvitation friendInvitation)
        {
            using (SPKTDataContext dc = conn.GetContext())
            {
                if (friendInvitation.FriendInvitationID> 0)
                {
                    dc.FriendInvitations.Attach(friendInvitation, true);
                }
                else
                {
                    friendInvitation.CreateDate = DateTime.Now;
                    dc.FriendInvitations.InsertOnSubmit(friendInvitation);
                }
                dc.SubmitChanges();
            }
        }
        public void CleanUpFriendInvitationsForThisEmail(FriendInvitation friendInvitation)
        {
            using (SPKTDataContext dc = conn.GetContext())
            {
                IEnumerable<FriendInvitation> friendInvitations = from fi in dc.FriendInvitations
                                                                  where fi.Email == friendInvitation.Email &&
                                                                    fi.BecameAccoutnID == 0 &&
                                                                    fi.AccountID == friendInvitation.AccountID
                                                                  select fi;
                foreach (FriendInvitation invitation in friendInvitations)
                {
                    dc.FriendInvitations.DeleteOnSubmit(invitation);
                }
                dc.SubmitChanges();
            }
        }
    }
}
