using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriber.FormalDefinition
{
    /// <summary>
    /// конкретная реализация интерфейса IObservable. Определяет коллекцию объектов наблюдателей.
    /// </summary>
    class ConcreteObservable : IObservable
    {
        /// <summary>
        /// списко подписчиков 
        /// </summary>
        private List<IObserver> observers;
        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update();
        }
    }
}
