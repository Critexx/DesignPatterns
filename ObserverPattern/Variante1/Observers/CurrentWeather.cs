namespace ObserverPattern.Variante1.Observers
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

        public void Update(decimal temperature, decimal airPressure, decimal airHumidity)
        {
            _temperatur = temperature;
            _airPressure = airPressure;
            _airHumidity = airHumidity;

            Show();
        }
    }
}