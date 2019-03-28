using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.FormalDefinition
{
    /// <summary>
    /// конкретная реализация команды, реализует метод Execute(),
    /// в котором вызывается определенный метод, определенный в классе Receiver
    /// </summary>
    class ConcreteCommand : Command
    {
        Receiver receiver;
        public ConcreteCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.Operation();
        }

        public override void Undo()
        { }
    }
}
