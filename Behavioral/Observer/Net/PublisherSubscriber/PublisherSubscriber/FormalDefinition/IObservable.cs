using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber.FormalDefinition
{

    /// <summary>
    /// представляет наблюдаемый объект. Определяет три метода: 
    /// AddObserver() (для добавления наблюдателя), 
    /// RemoveObserver() (удаление набюдателя) 
    /// NotifyObservers() (уведомление наблюдателей)
    /// </summary>
    interface IObservable
    {
        ///
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
