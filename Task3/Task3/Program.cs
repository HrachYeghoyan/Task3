using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class BankAcount 
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string HoldNumber { get; set; }

        public BankAcount(string accountnumber, decimal balance, string holdnumber) 
        {
            AccountNumber = accountnumber;
            Balance = balance;
            HoldNumber = holdnumber;
        }
        public void Deposid(decimal amount) 
        {
            if(amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit amaount: {amount} New Balance is: {Balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount can not be negativ: ");
            }

        }
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("for Withdraw amount can not be negativ");
            }
            else if (amount > Balance)
            {
                Console.WriteLine($"Withdraw can not be because Balance can not be negativ; Now Balance is {Balance} ");
            }
            else 
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw with amount {amount} done: Now new Balance is {Balance}");
            }
        }
        public void Despley()
        {
            Console.WriteLine($"Acountnumber: {AccountNumber} Balance: {Balance} HoldNumber: {HoldNumber}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please creating the Bank acount\n");
            Console.WriteLine("Please enther the Acount number: ");
            string acountnumber = Console.ReadLine();
            Console.WriteLine("Please Enther the Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enther the holdnumber ");
            string holdnumber = Console.ReadLine();
            BankAcount acount = new BankAcount(acountnumber, balance, holdnumber);
            Console.WriteLine("Creating Bankacount Done: ");
            acount.Despley();
            bool n = true;
            while (n)
            {
                Console.WriteLine("Please chose for Deposit 1\n for Withdraw 2\n for Exit 3\n");
                string x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        Console.WriteLine("Enther the deposed amount: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        acount.Deposid(amount);
                        break;
                    case "2":
                        Console.WriteLine("Enther the withdraw amount: ");
                        decimal withamount = Decimal.Parse(Console.ReadLine());
                        acount.Withdraw(withamount);
                        break;
                    case "3":
                        n = false;
                        break;
                    default:
                        Console.WriteLine("You are inpute the invaled chose:");
                        break ;

                }
            }
            Console.WriteLine("Program is End: ");
        }
    }
}
