using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDispatchNet
{
    class CompoundGraphic : Graphic
    {
        Graphic[] children { get; set; }     
        public void draw()
        {
            Console.WriteLine("Write compound graphics");
        }
    }
}
