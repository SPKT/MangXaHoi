using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace SPKTCore.Core
{
    [PluginFamily("Default")]
    public interface IRedirector
    {
        void GoToHomePage();
        void Redirect(String path);
        void GoToAccountLoginPage();
        void GoToAccountRegisterPage();
        void GoToAccountEditAccountPage();
        void GoToAccountRecoverPasswordPage();
        void GoToAccountAccessDenied();

        void GoToProfilesProfile();
    }
}
