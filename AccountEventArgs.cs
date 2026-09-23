using System;

namespace HW_T02_22_09_2026
{
    public class AccountEventArgs : EventArgs
    {
        public string Message { get; }
        public decimal Amount { get; }

        public AccountEventArgs(string message, decimal amount)
        {
            Message = message;
            Amount = amount;
        }
    }
}