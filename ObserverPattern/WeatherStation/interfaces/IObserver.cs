﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.interfaces
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
