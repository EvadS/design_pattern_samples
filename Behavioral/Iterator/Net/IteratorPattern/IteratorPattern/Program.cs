using IteratorPattern.FormalDeffinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: шаг 5 
            /*
            В клиентском коде и в классах коллекций не должно остаться кода обхода элементов.
            Клиент должен получать новый итератор из объекта коллекции каждый раз, когда ему нужно перебрать её элементы.
            */
            Aggregate a = new ConcreteAggregate();
            Iterator i = a.CreateIterator();

            if (!i.IsDone())
            {
                object item = i.First();
                while (!i.IsDone())
                {
                    item = i.Next();
                }
            }
            //------------------------------------------------------------------------------------------------------------

            // step 2 
            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }
}

