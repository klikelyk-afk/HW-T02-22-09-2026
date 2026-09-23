using System;

namespace HW_T02_22_09_2026
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public event EventHandler<AccountEventArgs> MoneyDeposited;
        public event EventHandler<AccountEventArgs> MoneyWithdrawn;

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) return;

            Balance += amount;
            MoneyDeposited?.Invoke(this, new AccountEventArgs($"Deposited {amount} USD. Balance: {Balance} USD", amount));
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) return;

            if (amount > Balance)
            {
                Console.WriteLine($"Insufficient funds to withdraw {amount} USD. Balance: {Balance} USD");
                return;
            }

            Balance -= amount;
            MoneyWithdrawn?.Invoke(this, new AccountEventArgs($"Withdrew {amount} USD. Balance: {Balance} USD", amount));
        }
    }
}