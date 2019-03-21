using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza p)
            : base(p.Name + ", с томатами", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 3;
        }
    }
}
