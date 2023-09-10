// Observer Pattern

// Es gibt grundsätzlich zwei Varianten wie mit dem Observer Pattern Informationen vom Subjekt
// an die Observers übermittelt werden:
// Variante 1: Informationen werden rausgeschoben. Sprich direkt im Parameter der Update-Methode übermittelt.
// Variante 2: Der Zustand muss herausgezogen werden. Sprich man übergibt die Subject Instanz
// und die Observer müssen Methodenaufrufe auf dem Subject ausführen oder dessen Properties lesen.

// Beide Varianten wurden implementiert. Grundsätzlich ist die Variante 1, in der die Informationen
// direkt übermittelt werden populärer. Siehe Buch "Entwurfsmuster von Kopf bis Fuss" Seite 63.

using WeatherData1 = ObserverPattern.Variante1.Subjects.WeatherData;
using CurrentWeather1 = ObserverPattern.Variante1.Observers.CurrentWeather;
using WeatherStatistic1 = ObserverPattern.Variante1.Observers.WeatherStatistic;

using WeatherData2 = ObserverPattern.Variante2.Subjects.WeatherData;
using CurrentWeather2 = ObserverPattern.Variante2.Observers.CurrentWeather;
using WeatherStatistic2 = ObserverPattern.Variante2.Observers.WeatherStatistic;
using ObserverPattern;

SimulateObserverPatternVariante1();
//SimulateObserverPatternVariante2();


void SimulateObserverPatternVariante1(){
	var weatherData = new WeatherData1();

	var currentWeather = new CurrentWeather1();
	var weatherStatistics = new WeatherStatistic1();

	weatherData.AttachObserver(currentWeather);
	weatherData.AttachObserver(weatherStatistics);

	weatherData.ChangeData(getDataFromMeasuringStation());

	Console.WriteLine();
	Console.WriteLine("Next Day, new Weather");
	Console.WriteLine();

	weatherData.ChangeData(getDataFromMeasuringStation());

	Console.WriteLine();
	Console.WriteLine("Next Day, new Weather");
	Console.WriteLine();

	weatherData.ChangeData(getDataFromMeasuringStation());

	// CurrentWeather deabonniert
	weatherData.DetachObserver(currentWeather);

	Console.WriteLine();
	Console.WriteLine("Next Day, new Weather");
	Console.WriteLine();

	weatherData.ChangeData(getDataFromMeasuringStation());
}

void SimulateObserverPatternVariante2()
{
	var weatherData = new WeatherData2();

	var currentWeather = new CurrentWeather2();
	var weatherStatistics = new WeatherStatistic2();

	weatherData.AttachObserver(currentWeather);
	weatherData.AttachObserver(weatherStatistics);

	weatherData.ChangeData(getDataFromMeasuringStation());

	Console.WriteLine();
	Console.WriteLine("Next Day, new Weather");
	Console.WriteLine();

	weatherData.ChangeData(getDataFromMeasuringStation());

	Console.WriteLine();
	Console.WriteLine("Next Day, new Weather");
	Console.WriteLine();

	weatherData.ChangeData(getDataFromMeasuringStation());

	// CurrentWeather deabonniert
	weatherData.DetachObserver(currentWeather);

	Console.WriteLine();
	Console.WriteLine("Next Day, new Weather");
	Console.WriteLine();

	weatherData.ChangeData(getDataFromMeasuringStation());
}

WeatherDataPoco getDataFromMeasuringStation()
{
	var rand = new Random();
	var rndDecimal = new decimal(rand.NextDouble());
	var temperatureDecimal = Math.Round(rndDecimal, 1);
	var temperatureDigit = rand.Next(0, 40);
	var temperature = temperatureDecimal + temperatureDigit;

	
	return new WeatherDataPoco
	       {
		       Temperatur = temperature,
		       AirHumidity = rand.Next(20, 90),
			   AirPressure = rand.Next(900, 1100)
};
}