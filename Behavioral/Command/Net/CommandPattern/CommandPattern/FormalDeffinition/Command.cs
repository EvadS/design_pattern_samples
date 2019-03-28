using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.FormalDefinition
{
    /// <summary>
    ///  интерфейс, представляющий команду. Обычно определяет метод Execute() для выполнения действия,
    ///  а также нередко включает метод Undo(), 
    ///  реализация которого должна заключаться в отмене действия команды
    /// </summary>
    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
