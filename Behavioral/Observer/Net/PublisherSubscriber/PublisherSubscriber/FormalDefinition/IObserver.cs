using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber.FormalDefinition
{
    /// <summary>
    /// представляет наблюдателя, который подписывается на все уведомления наблюдаемого объекта.
    /// Определяет метод Update(), который вызывается наблюдаемым объектом для уведомления наблюдателя.
    /// </summary>
    public interface IObserver
    {
        void Update();
    }
}
