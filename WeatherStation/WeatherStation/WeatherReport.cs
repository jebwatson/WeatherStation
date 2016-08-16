using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class WeatherReport
    {
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public int Rainfall { get; set; }
        public int Altitude { get; set; }
        public int WindSpeed { get; set; }
        public int WindDirection { get; set; }
    }
}
