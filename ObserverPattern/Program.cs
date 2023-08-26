// Observer Pattern

using ObserverPattern.Observers;
using ObserverPattern.Subjects;

var weatherData = new WeatherData();

var currentWeather = new CurrentWeather();
var weatherStatistics = new WeatherStatistic();

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