using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.base_decorator
{
    //конкретная реализация компонента, в которую с помощью декоратора добавляется новая функциональность
    class ConcreteComponent : Component
    {
        public override void Operation()
        { }
    }
}
