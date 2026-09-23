using System;
using System.Threading;

namespace HW_T02_22_09_2026
{
    public class WeatherStation
    {
        public event Action<double> TemperatureChanged;
        public event Action<double> HumidityChanged;

        private double _temperature;
        private double _humidity;

        public void StartMonitoring()
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);

                _temperature = random.Next(-10, 35);
                _humidity = random.Next(20, 95);

                TemperatureChanged?.Invoke(_temperature);
                HumidityChanged?.Invoke(_humidity);

                Console.WriteLine("----------------------------------");
            }
        }
    }
}