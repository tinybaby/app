using Evals.App.Infrastructure.Exception;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Evals.App.Infrastructure.Cache
{
    public class CacheManagerOptions
    {
        
        public string Server { get; set; }

        public int Port { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }



        public void Build(IConfiguration config)
        {
            this.Server = config["Server"];
            Port = config["Port"].TryToInt();
            UserName = config["UserName"];
            Password = config["Password"];
        }

        
    }
}
