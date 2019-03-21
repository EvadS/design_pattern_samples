using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        /// <summary>
        /// . В отличие от формальной схемы здесь установка 
        /// декорируемого объекта происходит не в методе SetComponent, а в конструкторе.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="pizza"></param>
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }
}
