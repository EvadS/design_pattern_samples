using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorNet.baseImpl;
using VisitorNet.doubleDespetcher;

namespace VisitorNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // base implementation
            var structure = new ObjectStructure();
            structure.Add(new ElementA());
            structure.Add(new ElementB());
            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());

            //---------------------------------
            doubleDespetcher.Visitor v = new doubleDespetcher.Visitor();
            Graphic g = new Dot();

            // Метод accept() – переопределен, но не перегружен. А значит, связан
            // динамически. Поэтому реализация `accept` будет выбрана во время выполнения 
            // уже из того класса, объект которого его вызвал (класс Dot).
            g.accept(v);
            //---------------------

            Console.WriteLine("Bank sample: ");
            testReal();
            Console.ReadLine();
        }

        private static void testReal()
        {

            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

        }
    }
}
