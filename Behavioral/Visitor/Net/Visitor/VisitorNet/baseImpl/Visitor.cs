using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorNet.baseImpl
{
    /// <summary>
    /// интерфейс посетителя, который определяет метод Visit() для каждого объекта Element
    /// </summary>
    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elemA);
        public abstract void VisitElementB(ElementB elemB);
    }
  
}
