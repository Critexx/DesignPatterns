namespace ObserverPattern.Variante1.Observers
{
    internal interface IObserver
    {
        void Update(decimal temperature, decimal airPressure, decimal airHumidity);
    }
}