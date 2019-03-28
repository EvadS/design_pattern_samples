using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.FormalDeffinition
{
    /// <summary>
    /// определяет интерфейс для обхода составных объектов
    /// 
    ///  IEnumerator
    ///  
    /// </summary>
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
        public abstract object HasNext();
    }

    /**
    шаг 1 
    Создайте общий интерфейс итераторов. Обязательный минимум — это операция получения следующего элемента коллекции.
    Но для удобства можно предусмотреть и другое. Например, методы для получения предыдущего элемента, текущей позиции,
    проверки окончания обхода и прочие.
    */
}
