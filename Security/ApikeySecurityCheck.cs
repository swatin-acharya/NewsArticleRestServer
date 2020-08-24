
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace kingpin.Security
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApikeySecurityCheck : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var headerApiKey = context.HttpContext.Request.Headers["ApiKey"];
            var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var systemApiKey = configuration.GetValue<string>("ApiKey");
            if (!headerApiKey.Equals(systemApiKey))
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}