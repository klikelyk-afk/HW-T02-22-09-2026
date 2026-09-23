using System;

namespace HW_T02_22_09_2026
{
    public class BankClient
    {
        public string Name { get; }

        public BankClient(string name)
        {
            Name = name;
        }

        public void OnNotificationReceived(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"[SMS for {Name}]: {e.Message}");
        }
    }
}