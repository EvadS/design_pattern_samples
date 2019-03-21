using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    // класс машины
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
