using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Momento.QuickImpl
{
    /// <summary>
    /// ыполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа к 
    /// хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит
    /// </summary>
    class Caretaker
    {
        public Memento Memento { get; set; }
    }
}
