using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.base_decorator
{
    // абстрактный класс, который определяет интерфейс для наследуемых объектов
    abstract class Component
    {
        public abstract void Operation();
    }
}
