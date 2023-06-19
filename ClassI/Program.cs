using System;
namespace ClassesI
{
    class BankAcct
    {
        private string name;
        public BankAcct(string nm){
            name = nm;
            Console.WriteLine($"Dear {name} Welcome to Automated Banking");
        }
        private double balance =0;
        public void Deposit(double n)
        {   balance += n;   }
        public void Withdraw(double n)
        { balance -= n; }
        public double GetBalance()
        { return balance; }
    }
    class Customer
    {
        static void Main(string[]args){
            Console.Write("User name: ");
            string nm = Console.ReadLine();
            BankAcct customer = new BankAcct(nm);

            Console.WriteLine("Select an option below;\n1.Deposit\n2.Withdraw\n3.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Console.Write("Amount = ");
                double money = Convert.ToDouble(Console.ReadLine());
                customer.Deposit(money);
                Console.WriteLine($"Acct Balance = {customer.GetBalance()}");
                break;

                case 2:
                Console.Write("Amount = ");
                double money = Convert.ToDouble(Console.ReadLine());
                customer.Withdraw(money);
                Console.WriteLine($"Acct Balance = {customer.GetBalance()}");
                break;

                case 3:
                Console.WriteLine("Thank you for banking with us");
                break;
                
                case default:
                Console.WriteLine("Inavlid Option");
                break;
            }
        }
    }
}