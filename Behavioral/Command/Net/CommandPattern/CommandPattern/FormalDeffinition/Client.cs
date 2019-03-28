using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.FormalDefinition
{
    /// <summary>
    /// клиент - создает команду и устанавливает ее получателя с помощью метода SetCommand()
    /// </summary>
    class Client
    {
        void Main()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            invoker.SetCommand(command);
            invoker.Run();
        }
    }
}
