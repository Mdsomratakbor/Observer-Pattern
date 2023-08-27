using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.interfaces;

namespace WeatherStation.subjects
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity; 
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
