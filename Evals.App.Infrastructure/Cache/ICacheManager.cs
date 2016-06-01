using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Cache
{
    public interface ICacheManager
    {
        /// <summary>
        /// 缓存数据
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="entityKey">缓存键</param>
        /// <param name="entity">缓存值</param>
        void Save<T>(string entityKey, T entity);

        /// <summary>
        /// 缓存数据
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="entityKey">缓存键</param>
        /// <param name="absoluteTimeout">绝对超时时间</param>
        /// <param name="relativeTimeout">相对超时时间</param>
        /// <param name="entity">缓存值</param>
        void Save<T>(string entityKey, AbsoluteExpiration absoluteTimeout, RelativeExpiration relativeTimeout, T entity);

        /// <summary>
        /// 获取缓存内容
        /// </summary>
        /// <typeparam name="T">值类型</typeparam>
        /// <param name="entityKey">缓存键</param>
        /// <returns>缓存值</returns>
        T Get<T>(string entityKey);



    }
}
