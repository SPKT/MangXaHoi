using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace SPKTCore.Core
{
    [PluginFamily("Default")]
    public interface IAccountService
    {
        bool UsernameInUse(string Username);
        bool EmailInUse(string Email);
        string Login(string Username, string Password);
        void Logout();
       
    }
}
