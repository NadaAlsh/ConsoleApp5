// See https://aka.ms/new-console-template for more information

using ConsoleApp5;
 static Account InitializeAccount()
{

    Console.WriteLine("Welcome to the Basic Banking Application ");

    Console.WriteLine("Enter your name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter your initial account number: ");
    int accountNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your initial balance amount: ");
    double balance = Convert.ToDouble(Console.ReadLine());

    return new Account(name, accountNumber, balance);


    Console.WriteLine("Account setup successful! ");
}
Account account = InitializeAccount(); 

bool exit = false;

while (!exit)
{
    Console.WriteLine("\nSelect an option:");
    Console.WriteLine("1: Deposit");
    Console.WriteLine("2: Withdraw");
    Console.WriteLine("3: View Balance");
    Console.WriteLine("4: View Transaction History");
    Console.WriteLine("5: Exit");

    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Enter deposit amount: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(depositAmount);
            break;
        case 2:
            Console.Write("Enter withdrawal amount: ");
            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdrawalAmount);
            break;
        case 3:
            account.getBalance();
            break;
        case 4:
            account.PrintTransactionHistory();
            break;
        case 5:
            exit = true;
            break;
        default:
            Console.WriteLine("Invalid option, enter another option");
            break;
    }
//    Console.WriteLine("\nDo you want to perform another transaction? (y/n)");
//    string response = Console.ReadLine();
//    if (response.ToLower() != "y")
//    {
//        exit = true;
//    }

//account.PrintTransactionHistory();
}
