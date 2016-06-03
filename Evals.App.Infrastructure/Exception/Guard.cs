using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Exception
{
    public class Guard
    {
        public static void ArgumentNotNull<T>(Func<T> action)
        {
            var result = action();
            if (result == null)
                throw new ArgumentNullException($"参数{nameof(action)}不能为空");

        }
    }
}
