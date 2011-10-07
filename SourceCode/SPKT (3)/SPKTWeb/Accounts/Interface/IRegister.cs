using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPKTWeb.Accounts.Interface
{
    public interface IRegister
    {
        void ShowErrorMessage(string Message);
   
        
        void LoadEmailAddressFromFriendInvitation(string Email);
    }
}