using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// определяет методы для создания объектов. Причем методы возвращают абстрактные продукты, а не их конкретные реализации.
    /// </summary>
    abstract class AbstractFactory
    {
        ///
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
