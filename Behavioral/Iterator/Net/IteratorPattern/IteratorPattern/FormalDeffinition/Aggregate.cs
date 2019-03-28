using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.FormalDeffinition
{
    /// <summary>
    /// определяет интерфейс для создания объекта-итератора
    /// 
    /// IEnumerable
    /// 
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; protected set; }
        public abstract object this[int index] { get; set; }
    }

    /*
    шаг 2
    Создайте интерфейс коллекции и опишите в нём метод получения итератора. 
    Важно, чтобы сигнатура метода возвращала общий интерфейс итераторов, а не один из конкретных итераторов.
    */
}
