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
                    return false;
                }
            }   
            set
            {
                SetInSession("LoggedIn", value);
            }
        }

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

        private string GetQueryStringValue(string key)
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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

 }
