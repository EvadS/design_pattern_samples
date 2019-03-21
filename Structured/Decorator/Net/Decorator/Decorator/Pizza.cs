using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    ///компонент
    /// </summary>
    abstract class Pizza
    {
        public Pizza(string n)
        {
            this.Name = n;
        }
        /// <summary>
        ///  название пиццы
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// цена
        /// </summary>
        /// <returns></returns>
        public abstract int GetCost();
    }
}
