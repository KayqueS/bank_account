using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    class Account
    {
        public int AccountNumber { get; private set; }
        public string OwnerAccount { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber, string ownerAccount)
        {
            AccountNumber = accountNumber;
            OwnerAccount = ownerAccount;
        }

        public Account(int accountNumber, string ownerAccount, double balance) : this(accountNumber, ownerAccount)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }



        public override string ToString()
        {
            return $"Account {AccountNumber}, Owner: {OwnerAccount}, Balance: $ {Balance:F2}";
        }
    }
}
