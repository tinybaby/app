using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evals.App.Infrastructure.Events
{
    public interface IConsumerFactory<T>
    {
        IEnumerable<IConsumer<T>> GetConsumers(bool? resolveAsyncs = null);

        bool HasAsyncConsumer { get; }
    }
}
