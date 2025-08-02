using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace CP2.Interfaces
{
    protected interface IAuth : IAuthenticationFilter, IAuthorizationFilter
    {
    }
}
