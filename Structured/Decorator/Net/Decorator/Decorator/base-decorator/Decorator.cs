using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.base_decorator
{
    /// <summary>
    /// декоратор, реализуется в виде абстрактного класса и имеет тот же базовый класс, что и декорируемые объекты. 
    /// Поэтому базовый класс Component должен быть по возможности легким и определять только базовый интерфейс.
    /// </summary>
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }
}
