using WeatherStation.subjects;

Console.WriteLine("Welcome to the Weather O Rama Station");
Console.WriteLine("Enter {temparature} {humidity} {pressure}");
var data =  Console.ReadLine();


WeatherData weather = new WeatherData();

weather.SetMeasurements((float)data[0], (float)(data[1]), (float)(data[2]));