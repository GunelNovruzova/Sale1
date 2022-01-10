using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Burcak",2.50, Producttype.Bakery);
            Console.WriteLine(product);
        }
    }
}
