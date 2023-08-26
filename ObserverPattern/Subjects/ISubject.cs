using ObserverPattern.Observers;

namespace ObserverPattern.Subjects
{
	internal interface ISubject
	{
		void AttachObserver(IObserver observer);

		void DetachObserver(IObserver observer);

		void NotifyObserver();
	}
}