using System;

namespace HW_T02_22_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== TASK 1: WEATHER STATION ===\n");

            WeatherStation station = new WeatherStation();
            WeatherDisplay display = new WeatherDisplay();

            station.TemperatureChanged += display.OnTemperatureChanged;
            station.HumidityChanged += display.OnHumidityChanged;

            station.StartMonitoring();

            Console.WriteLine("\n==================================\n");


            Console.WriteLine("=== TASK 2: BANK ACCOUNT ===\n");

            BankAccount account = new BankAccount(1000);
            BankClient client = new BankClient("Yelisei");

            account.MoneyDeposited += client.OnNotificationReceived;
            account.MoneyWithdrawn += client.OnNotificationReceived;

            account.Deposit(500);
            account.Withdraw(300);
            account.Withdraw(2000);
        }
    }
}