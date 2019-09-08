using System;
using System.Collections.Generic;
using System.Text;

namespace TheWather.Models
{
    public class Main : BaseModel
    {
        private double temp;
        private double pressure;
        private int humidity;
        private double temp_Max;
        private double temp_Min;
        private double sea_level;
        private double grnd_level;
        public double Temp
        {
            get=>temp;
            set=>SetProperty(ref temp ,value);
        }
        public double Pressure
        {
            get => pressure;
            set => SetProperty(ref pressure, value);
        }
        public int Humidity
        {
            get => humidity;
            set => SetProperty(ref humidity, value);
        }
        public double Temp_Min
        {
            get => temp_Min;
            set => SetProperty(ref temp_Min, value);
        }
        public double Temp_Max
        {
            get => temp_Max;
            set => SetProperty(ref temp_Max, value);
        }
        public double Sea_level
        {
            get => sea_level;
            set => SetProperty(ref sea_level, value);
        }
        public double Grnd_level
        {
            get => grnd_level;
            set => SetProperty(ref grnd_level, value);
        }
    }
}
