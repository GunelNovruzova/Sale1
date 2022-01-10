using ConsoleApp2.Models;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cash = new CashRegister(300, Enum.Currency.USD);
            cash.AddNewSale(340, Enum.Currency.AZN);
            Console.WriteLine(cash);
        }
    }
}
