using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPKTCore.Core.Domain;

namespace SPKTWeb.Profiles.Interface
{
    public interface IUserProfile
    {
        void LoadAlert(List<Alert> listAlert);
        void Message(string message);

        void LoadAlertUserProfile(List<Alert> listAlert);
    }
}