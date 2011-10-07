using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core
{
    public interface IWebContext
    {
        void ClearSession();
        bool ContainsInSession(string key);
        void RemoveFromSession(string key);
        bool LoggedIn { get; set; }
        Account CurrentUser { get; set; }
        string Username { get; set; }
        string CaptchaImageText { get; set; }

        String UsernameToVerify { get; }

        string RootUrl { get; set; }
    }
}
