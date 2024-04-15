using System;

namespace ConsoleApp5
{
    public class Account
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        private Transaction[] transactionHistory;
        private int transactionIndex;

        public Account(string name, int accountNumber, double balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
            this.transactionHistory = new Transaction[100];
            this.transactionIndex = 0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Transaction transaction = new Transaction(DateTime.Now, (decimal)amount, "Deposit");
            transactionHistory[transactionIndex] = transaction;
            transactionIndex++;
            Console.WriteLine($"Deposited {amount} KWD to the account. New balance: {Balance} KWD");
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Transaction transaction = new Transaction(DateTime.Now, (decimal)amount, "Withdrawal");
                transactionHistory[transactionIndex] = transaction;
                transactionIndex++;
                Console.WriteLine($"Withdrew {amount} KWD from the account. New balance: {Balance} KWD");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void getBalance()
        {
            Console.WriteLine($"Account Balance: {Balance} KWD");
        }

        public void PrintTransactionHistory()
        {
            Console.WriteLine("Transaction history:");
            for (int i = 0; i < transactionIndex; i++)
            {
                Transaction transaction = transactionHistory[i];
                Console.WriteLine($"{transaction.Date.ToShortDateString()} - {transaction.Type} - Amount: {transaction.Amount} KWD");
            }
        }
    }

    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }

        public Transaction(DateTime date, decimal amount, string type)
        {
            Date = date;
            Amount = amount;
            Type = type;
        }
    }
}