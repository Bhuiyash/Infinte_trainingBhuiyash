using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions
{
    class Accounts
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public char TransactionType;
        public double Amount;
        public double Balance;
        public Accounts(int acno,string cname,string actype,char trantype, double amt)
        {
            AccountNo = acno;
            CustomerName = cname;
            AccountType = actype;
            TransactionType = trantype;
            Amount = amt;
            if (TransactionType == 'D' || TransactionType == 'd') { creditPlusAmount(Amount); } else { debitMinusAmount(Amount); }
        }
        public void creditPlusAmount(double amount)
        {
            Balance += amount;
        }
        public void debitMinusAmount(double amount)
        {
            if (Balance > amount) { Balance -= amount; } else { Console.WriteLine("not enough balance in account.");Console.ReadLine(); }
        }

        public void showData()
        {
            Console.WriteLine($"Account no : {AccountNo}");
            Console.WriteLine($"Customer name : {CustomerName}");
            Console.WriteLine($" Account type : {AccountType}");
            Console.WriteLine($"Transaction type : {TransactionType}");
            Console.WriteLine($"Amount : {Amount}");
            Console.WriteLine($"Balance : {Balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accounts obj = new Accounts(123, "Bhuiyash Kumar", "savings account", 'd', 100000);
            obj.showData();
            Console.WriteLine(".............................");
            obj = new Accounts(123, "Bhuiyash Kumar", "savings accounts", 'w', 3000);
            obj.showData();
            Console.ReadLine();
        }
    }
}