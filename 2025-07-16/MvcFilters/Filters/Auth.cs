using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MvcFilters.Filters
{
    public class Auth : IAuthenticationFilter, IAuthorizationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            // filterContext.Result = new HttpUnauthorizedResult();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            // filterContext.Result = new RedirectResult("/Home/Index");
            // throw new NotImplementedException();
        }

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            // throw new NotImplementedException();
        }
    }
}