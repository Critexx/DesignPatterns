using ObserverPattern.Variante2.Observers;

namespace ObserverPattern.Variante2.Subjects
{
    internal interface ISubject
    {
        void AttachObserver(IObserver observer);

        void DetachObserver(IObserver observer);

        void NotifyObserver();
    }
}