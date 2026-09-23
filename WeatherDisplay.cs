using System;

namespace HW_T02_22_09_2026
{
    public class WeatherDisplay
    {
        public void OnTemperatureChanged(double newTemperature)
        {
            Console.WriteLine($"New temperature: {newTemperature}°C");
        }

        public void OnHumidityChanged(double newHumidity)
        {
            Console.WriteLine($"New humidity: {newHumidity}%");
        }
    }
}