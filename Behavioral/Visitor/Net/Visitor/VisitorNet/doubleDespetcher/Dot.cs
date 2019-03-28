using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorNet.doubleDespetcher
{
    class Dot : Shape
    {
        public override void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
