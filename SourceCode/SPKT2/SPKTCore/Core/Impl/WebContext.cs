using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using System.Web;
using SPKTCore.Core.Domain;

namespace SPKTCore.Core.Impl
{
    [Pluggable("Default")]
    public class WebContext : IWebContext
    {
        
        public string CaptchaImageText
        {
            get
            {
                if(ContainsInSession("CaptchaImageText"))
                {
                    return GetFromSession("CaptchaImageText").ToString();
                }

                return null;
            }
            set
            {
                SetInSession("CaptchaImageText",value);
            }
        }
        public Account CurrentUser
        {
            get
            {
                if(ContainsInSession("CurrentUser"))
                {
                    return GetFromSession("CurrentUser") as Account;
                }

                return null;
            }
            set
            {
                SetInSession("CurrentUser", value);
            }
        }
        public Profile CurrentProfile
        {
            get
            {
                if (ContainsInSession("CurrentProfile"))
                {
                    return GetFromSession("CurrentProfile") as Profile;
                }

                return null;
            }
            set
            {
                SetInSession("CurrentProfile", value);
            }
        }
      
        public string Username
        {
            get
            {
                if(ContainsInSession("Username"))
                {
                    return GetFromSession("Username").ToString();
                }

                return "";
            }

            set
            {
                SetInSession("Username",value);
            }
        }

        public void SaveLoginInfoToCookie(String username, String password)
        {
            HttpCookie cook = new HttpCookie("Login");
            cook["Username"] = username;
            cook["Password"] = password;
            cook.Expires = DateTime.Now.AddDays(20);
            WriteToCookie(cook);
        }
        public bool LoginInUseCookie()
        {
            HttpCookie cookLogin = GetInCookie("Login");
            if (cookLogin == null)
                return false;            
            String username = cookLogin["UserName"];
            String pass = cookLogin["Password"];
            IAccountService accountService = new SPKTCore.Core.Impl.AccountService();
            return accountService.Login(username, pass);
        }
        public bool LoggedIn
        {
            get
            {
                if(ContainsInSession("LoggedIn"))
                {
                    if((bool)GetFromSession("LoggedIn"))
                        return true;
                    else
                        return false;
                }
                else
                {
                    return LoginInUseCookie();
                }
            }   
            set
            {
                SetInSession("LoggedIn", value);
            }
        }

        private HttpCookie GetInCookie(string name)
        {
            if (HttpContext.Current == null || HttpContext.Current.Session == null)
            {
                return null;
            }
            return HttpContext.Current.Request.Cookies[name];
        }
        private void WriteToCookie(HttpCookie value)
        {
            if (HttpContext.Current == null || HttpContext.Current.Session == null)
            {
                return ;
            }

            HttpContext.Current.Response.Cookies.Add(value);
        }
        private void RemoveCookie(string name)
        {
            if (HttpContext.Current == null || HttpContext.Current.Session == null)
            {
                return;
            }
            HttpCookie ck = new HttpCookie(name);
            ck.Expires = DateTime.Now.AddDays(-2);
            HttpContext.Current.Response.Cookies.Add(ck);
        }
        //lay username từ chuỗi mã hóa trong link xác nhận mail
        public string UsernameToVerify
        {
            get
            {
                return GetQueryStringValue(ParameterSetting.UsernameToVerifyQueryStringName).ToString();
            }
        }

        public void ClearSession()
        {
            HttpContext.Current.Session.Clear();
        }

        public bool ContainsInSession(string key)
        {
            return HttpContext.Current.Session[key] != null;
        }

        public void RemoveFromSession(string key)
        {
            HttpContext.Current.Session.Remove(key);
        }
        // lấy giá trị key của query string
        public string GetQueryStringValue(string key)
        {
            return HttpContext.Current.Request.QueryString[key];
        }


        private void SetInSession(string key, object value)
        {
            if (HttpContext.Current == null || HttpContext.Current.Session == null)
            {
                return;
            }
            HttpContext.Current.Session[key] = value;
        }

        private object GetFromSession(string key)
        {
            if (HttpContext.Current == null || HttpContext.Current.Session == null)
            {
                return null;
            }
            return HttpContext.Current.Session[key];
        }

        private void UpdateInSession(string key, object value)
        {
            HttpContext.Current.Session[key] = value;
        }


        public string RootUrl
        {
            //TODO: Chua biet lam gi
            get
            {
                string result;

                string Port = HttpContext.Current.Request.ServerVariables["SERVER_PORT"];
                if (Port == null || Port == "80" || Port == "443")
                    Port = "";
                else
                    Port = ":" + Port;

                string Protocol = HttpContext.Current.Request.ServerVariables["SERVER_PORT_SECURE"];
                if (Protocol == null || Protocol == "0")
                    Protocol = "http://";
                else
                    Protocol = "https://";

                result = Protocol + HttpContext.Current.Request.ServerVariables["SERVER_NAME"] +
                    Port + HttpContext.Current.Request.ApplicationPath;

                return result;
            }
        }
    }

 }
