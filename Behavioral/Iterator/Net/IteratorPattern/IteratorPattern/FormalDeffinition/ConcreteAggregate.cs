using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.FormalDeffinition
{
    /// <summary>
    /// конкретная реализация Aggregate. Хранит элементы, которые надо будет перебирать
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override int Count
        {
            get { return _items.Count; }
            protected set { }
        }

        public override object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }

    //TODO: шаг 4
    /*
    Реализуйте методы получения итератора в конкретных классах коллекций.
    Они должны создавать новый итератор того класса, который способен работать с данным типом коллекции.
    Коллекция должна передавать ссылку на собственный объект в конструктор итератора
    */
}
