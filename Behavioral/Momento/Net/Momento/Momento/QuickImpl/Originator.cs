using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento.QuickImpl
{
    /// <summary>
    /// создает объект хранителя для сохранения своего состояния
    /// </summary>
    class Originator
    {
        public string State { get; set; }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
    }
}
