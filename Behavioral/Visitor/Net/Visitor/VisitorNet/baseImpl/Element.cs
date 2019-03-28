using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorNet.baseImpl
{
    /// <summary>
    /// определяет метод Accept(), в котором в качестве параметра принимается объект Visitor
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
        public string SomeState { get; set; }
    }
}
