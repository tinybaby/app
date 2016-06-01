using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Events
{
    public interface IConsumer<T>
    {
        void HandleEvent(T eventMessage);
    }
}
