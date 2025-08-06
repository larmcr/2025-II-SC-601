using CP2.Interfaces;
using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace CP2.Attributes
{
    public class AuthAttribute : ActionFilterAttribute, IAuth
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}