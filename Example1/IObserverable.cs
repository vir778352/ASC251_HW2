using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    interface IObserverable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void Notify();
    }
}
