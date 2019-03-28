using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorNet.doubleDespetcher
{
    interface Graphic
    {
        void accept(Visitor visitor);
    }
}
