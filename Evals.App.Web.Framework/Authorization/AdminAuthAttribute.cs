using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Evals.App.Web.Framework.Authorization
{
    public class AdminAuthAttribute : AuthorizeAttribute
    {
        public AdminAuthAttribute() : base("AdminAuth")
        {

        }
    }
}
