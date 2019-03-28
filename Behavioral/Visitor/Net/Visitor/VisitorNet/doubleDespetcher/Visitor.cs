using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorNet.doubleDespetcher
{
    class Visitor
    {
        public void visit(Shape shape)
        {
            Console.WriteLine("Visited shape");
        }

        public void visit(Dot dot)
        {
            Console.WriteLine("Visited dot");
        }
    }
}
