using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorNet.doubleDespetcher
{
    class Shape : Graphic
    {
        public virtual void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
