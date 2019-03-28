using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento.QuickImpl
{
    /// <summary>
    /// хранитель, который сохраняет состояние объекта Originator и
    /// предоставляет полный доступ только этому объекту Originator
    /// </summary>
    class Memento
    {
        public string State { get; private set; }
        public Memento(string state)
        {
            this.State = state;
        }
    }

}
