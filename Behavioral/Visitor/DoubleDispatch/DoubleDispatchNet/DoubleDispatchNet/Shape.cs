using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDispatchNet
{
    class Shape : Graphic
    {
        int id;

        void Graphic.draw()
        {
            Console.WriteLine("draw Shape");
        }
    }
}