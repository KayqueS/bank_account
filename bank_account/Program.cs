using System;

namespace bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bank;

            Console.Write("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Sign in with the account holder: ");
            string ownerAccount = Console.ReadLine();

            Console.Write("There will be an initial deposit (Y/N)? ");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'Y' || answer == 'y')
            {
                Console.Write("Enter the initial deposit amount: $");
                double deposit = double.Parse(Console.ReadLine());
                bank = new Account(accountNumber, ownerAccount, deposit);
            }
            else
            {
                bank = new Account(accountNumber, ownerAccount);
            }

            Console.WriteLine();
            Console.WriteLine("Account Data:");
            Console.WriteLine(bank);

            Console.WriteLine();
            Console.Write("Enter a deposit amount: $");
            double amount = double.Parse(Console.ReadLine());
            bank.Deposit(amount);
            Console.WriteLine("Updated Account Data:");
            Console.WriteLine(bank);

            Console.WriteLine();
            Console.Write("Enter a withdrawal amount: $");
            amount = double.Parse(Console.ReadLine());
            bank.Withdraw(amount);
            Console.WriteLine("Updated Account Data:");
            Console.WriteLine(bank);

        }
    }
}
