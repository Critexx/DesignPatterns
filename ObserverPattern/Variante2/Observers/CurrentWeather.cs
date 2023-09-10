using ObserverPattern.Variante2.Subjects;

namespace ObserverPattern.Variante2.Observers
{
    internal class CurrentWeather : IObserver, IShow
    {
        #region Fields
        private decimal _temperatur;
        private decimal _airPressure;
        private decimal _airHumidity;
        #endregion

        #region Publics
        public void Show()
        {
            Console.WriteLine($"Aktuelle Temperatur: {_temperatur}°");
            Console.WriteLine($"Aktueller Luftdruck: {_airPressure} hPa");
            Console.WriteLine($"Aktuelle Luftfeuchtigkeit: {_airHumidity}%");
        }
        #endregion

        public void Update(WeatherData weatherData)
        {
            _temperatur = weatherData.Temperatur;
            _airPressure = weatherData.AirPressure;
            _airHumidity = weatherData.AirHumidity;

            Show();
        }
    }
}