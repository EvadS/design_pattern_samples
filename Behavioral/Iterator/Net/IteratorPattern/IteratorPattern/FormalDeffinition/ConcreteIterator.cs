using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.FormalDeffinition
{
    /// <summary>
    /// : конкретная реализация итератора для обхода объекта Aggregate. Для фиксации индекса текущего 
    /// перебираемого элемента использует целочисленную переменную _current
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private readonly Aggregate _aggregate;
        private int _current;

        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;          

            _current++;

            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object HasNext()
        {
            throw new NotImplementedException();
        }

    }

    // TODO: шаг 3 
    /* 
    Создайте классы конкретных итераторов для тех коллекций, которые нужно обходить с помощью паттерна. 
    Итератор должен быть привязан только к одному объекту коллекции. Обычно эта связь устанавливается через конструктор.
    */
}
