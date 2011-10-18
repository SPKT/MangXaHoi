using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core
{
    public interface IAlertService
    {
        void AddAccountCreatedAlert();
        void AddAccountModifiedAlert();
        void AddProfileCreatedAlert();
        void AddProfileModifiedAlert();
        void AddNewAvatarAlert();
        List< Alert> GetAlertsByAccountID(Int32 AccountID);
    }
}
