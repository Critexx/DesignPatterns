using ObserverPattern.Variante1.Observers;

namespace ObserverPattern.Variante1.Subjects
{
    internal interface ISubject
    {
        void AttachObserver(IObserver observer);

        void DetachObserver(IObserver observer);

        void NotifyObserver();
    }
}