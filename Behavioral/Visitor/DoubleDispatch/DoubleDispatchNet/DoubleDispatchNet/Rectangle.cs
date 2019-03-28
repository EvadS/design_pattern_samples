using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDispatchNet
{
    class Rectangle : Shape
    {
        int width, height;
        void draw()
        {
            Console.WriteLine("draw Shape");
        }
    }
}
