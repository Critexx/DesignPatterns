using ObserverPattern.Variante2.Subjects;

namespace ObserverPattern.Variante2.Observers
{
    internal interface IObserver
    {
        void Update(WeatherData weatherData);
    }
}