namespace ObserverPattern.Observers
{
	internal interface IObserver
	{
		void Update(decimal temperature, decimal airPressure, decimal airHumidity);
	}
}