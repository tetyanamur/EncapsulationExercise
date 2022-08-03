using System;

namespace EncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Deposit?");
            var amountToDep = double.Parse(Console.ReadLine());
            account.Deposit(amountToDep);
            Console.WriteLine($"Thank you. Balance is now {account.Getbalance()}");
        }
    }
}
