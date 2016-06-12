using Evals.App.Infrastructure.Cache;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Caching.Redis;

namespace Evals.App.Redis
{
    internal class CacheManager : ICacheManager
    {
        private IDistributedCache _distributedCache;
        private Encoding _encoding = Encoding.UTF8;

        public CacheManager(IOptions<RedisCacheOptions> options)
        {
            _distributedCache = new RedisCache(options);
        }

        public T Get<T>(string entityKey)
        {
            var data = _distributedCache.Get(entityKey);
            var d = JsonConvert.DeserializeObject<T>(_encoding.GetString(data));
            return d;

        }

        public void Save<T>(string entityKey, T entity)
        {
            Save(entityKey, null, null, entity);
        }

        public void Save<T>(string entityKey, DateTimeOffset? absoluteExpiration, TimeSpan? slidingExpiration, T entity)
        {
            var serializedObject = JsonConvert.SerializeObject(entity);
            var data = _encoding.GetBytes(serializedObject);
            _distributedCache.Set(entityKey, data, new DistributedCacheEntryOptions()
            {
                AbsoluteExpiration = absoluteExpiration,
                SlidingExpiration = slidingExpiration
            });
        }

        public Task SaveAsync<T>(string entityKey, T entity)
        {
            return SaveAsync(entityKey, null, null, entity);
        }

        public Task SaveAsync<T>(string entityKey, DateTimeOffset? absoluteExpiration, TimeSpan? slidingExpiration, T entity)
        {
            var serializedObject = JsonConvert.SerializeObject(entity);
            var data = _encoding.GetBytes(serializedObject);
            return _distributedCache.SetAsync(entityKey, data, new DistributedCacheEntryOptions()
            {
                AbsoluteExpiration = absoluteExpiration,
                SlidingExpiration = slidingExpiration
            });
        }
    }
}
