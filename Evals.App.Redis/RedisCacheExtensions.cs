using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Evals.App.Infrastructure.Cache;
using Evals.App.Redis;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RedisCacheExtensions
    {
        public static IServiceCollection AddCache(this IServiceCollection service, Action<CacheOptionsBuilder> builder)
        {
            service.AddSingleton<ICacheManager, CacheManager>();
            
            return service;
        }
    }
}
