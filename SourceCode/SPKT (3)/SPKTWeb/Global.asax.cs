using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using StructureMap;
using SPKTCore.Core.Domain;
using SPKTCore.Core.DataAccess;
using SPKTCore.Core.Impl;
using SPKTCore.Core;
using SPKTCore.Core.DataAccess.Impl;

namespace SPKTWeb
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
           /* var container = new Container(x =>{
                x.For<IAccountRepository>().Use<AccountRepository>(); 
                x.For<IEmail>().Use<Email>();
                x.For<IUserSession>().Use<UserSession>();
                x.For<IRedirector>().Use<Redirector>();
                x.For<IPermissionRepository>().Use<PermissionRepository>();
                x.For<IAccountService>().Use<AccountService>();
                x.For<IWebContext>().Use<WebContext>();
                x.For<ICaptcha>().Use<Captcha>();
            });
            container.AssertConfigurationIsValid();*/
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
