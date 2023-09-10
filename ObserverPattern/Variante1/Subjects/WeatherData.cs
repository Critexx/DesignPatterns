using ObserverPattern.Variante1.Observers;

namespace ObserverPattern.Variante1.Subjects
{
    internal class WeatherData : ISubject
    {
        private decimal _temperatur;
        private decimal _airPressure;
        private decimal _airHumidity;

        public List<IObserver> _myObservers;

        public WeatherData()
        {
            _myObservers = new List<IObserver>();
        }

        #region Publics
        public void AttachObserver(IObserver observer)
        {
            if (_myObservers.Contains(observer)) return;

            _myObservers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            _myObservers.Remove(observer);
        }

        public void NotifyObserver()
        {
            _myObservers.ForEach(observer => observer.Update(_temperatur,
                                                             _airPressure,
                                                             _airHumidity));
        }

        /// <summary>
        /// Wird von aussen getriggert, wenn sich z.B. die Messdaten der Wetterstation
        /// ändern.
        /// </summary>
        public void ChangeData(WeatherDataPoco weatherDataPoco)
        {
            _temperatur = weatherDataPoco.Temperatur;
            _airPressure = weatherDataPoco.AirPressure;
            _airHumidity = weatherDataPoco.AirHumidity;
            NotifyObserver();
        }
        #endregion
    }
}