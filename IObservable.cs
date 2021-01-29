using System.Collections.Generic;

namespace OO_Seminar
{
    public interface IObservable
    {

        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
