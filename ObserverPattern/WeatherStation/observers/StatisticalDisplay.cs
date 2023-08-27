using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.interfaces;
using WeatherStation.subjects;

namespace WeatherStation.observers
{
    public class StatisticalDisplay : IObserver, IDisplayElement
    {
        public float temparature;
        public float humidity;
        public WeatherData weatherData;
        public StatisticalDisplay(WeatherData weatherData) {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Current Conditions: {temparature} °C and  and {humidity} % humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temparature  = temp;
            this.humidity = humidity;
            
  
        }
    }
}
