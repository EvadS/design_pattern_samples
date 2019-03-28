using Mediator.Conceptual;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
            //-----------------------------------------------------------------


            ManagerMediator mediator = new ManagerMediator();

            Colleague customer = new CustomerColleague(mediator);
            Colleague programmer = new ProgrammerColleague(mediator);
            Colleague tester = new TesterColleague(mediator);

            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;

            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");

         
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }
    }
}
