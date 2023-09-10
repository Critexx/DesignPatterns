namespace ObserverPattern.Variante1.Observers
{
    internal class WeatherStatistic : IObserver, IShow
    {
        #region Fields
        private List<decimal> _temperatureHistory;
        private decimal _maxTemperatur;
        private decimal _minTemperatur;
        private decimal _averageTemperatur;

        public WeatherStatistic()
        {
            _temperatureHistory = new List<decimal>();
        }
        #endregion

        #region Publics
        public void Show()
        {
            Console.WriteLine($"Höchste Temperatur: {_maxTemperatur}°");
            Console.WriteLine($"Niedrigste Temperatur: {_minTemperatur}°");
            Console.WriteLine($"Durchschnittliche Temperatur: {_averageTemperatur}°");
        }
        #endregion

        public void Update(decimal temperature, decimal airPressure, decimal airHumidity)
        {
            _temperatureHistory.Add(temperature);
            _minTemperatur = _temperatureHistory.Min();
            _maxTemperatur = _temperatureHistory.Max();
            _averageTemperatur = _temperatureHistory.Average();

            Show();
        }
    }
}