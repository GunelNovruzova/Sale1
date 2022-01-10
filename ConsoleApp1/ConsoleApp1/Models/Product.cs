using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Product
    {
        private static int count = 1000;
        private static int Totalcount;
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public  Producttype Type { get; set; }
        public string Code { get; set; }
        public Product(string name,double price,  Producttype type)
        {
            count++;
            
            Name = name;
            Price = price;
            Type = type;
            
            Totalcount++;

           
            
            switch ((int)Type)
            {
                case (int)Producttype.Bakery:
                    Code += "B" + count;
                    DiscountedPrice = price - (price * 0.1);
                    break;
                case (int)Producttype.Drink:
                    Code += "D" + count;
                    break;
                case (int)Producttype.Fish:
                    Code += "F" + count;
                    break;
                case (int)Producttype.Meat:
                    Code += "M" + count;
                    break;
               
            }


        }
        public override string ToString()
        {
            return $"{Name} {Type} {Totalcount} {DiscountedPrice} {Code}";
        }
    }
}
