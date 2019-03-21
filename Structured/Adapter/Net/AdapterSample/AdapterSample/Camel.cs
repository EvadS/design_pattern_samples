using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    // класс верблюда
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}
