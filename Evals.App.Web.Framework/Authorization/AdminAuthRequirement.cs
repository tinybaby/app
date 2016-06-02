using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Web.Framework.Authorization
{
    public class AdminAuthRequirement : AuthorizationHandler<AdminAuthRequirement>, IAuthorizationRequirement
    {
        protected override void Handle(AuthorizationContext context, AdminAuthRequirement requirement)
        {
            context.Succeed(requirement);
        }
        
    }
}
