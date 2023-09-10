using ObserverPattern.Variante2.Observers;

namespace ObserverPattern.Variante2.Subjects
{
    internal class WeatherData : ISubject
    {
	    public decimal Temperatur { get; private set; }
	    public decimal AirPressure { get; private set; }
	    public decimal AirHumidity { get; private set; }

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
            _myObservers.ForEach(observer => observer.Update(this));
        }

        /// <summary>
        /// Wird von aussen getriggert, wenn sich z.B. die Messdaten der Wetterstation
        /// ändern.
        /// </summary>
        public void ChangeData(WeatherDataPoco weatherDataPoco)
        {
            this.Temperatur = weatherDataPoco.Temperatur;
            this.AirPressure = weatherDataPoco.AirPressure;
            this.AirHumidity = weatherDataPoco.AirHumidity;
            NotifyObserver();
        }
        #endregion
    }
}