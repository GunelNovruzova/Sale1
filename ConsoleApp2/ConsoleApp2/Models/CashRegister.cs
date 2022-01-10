using ConsoleApp2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class CashRegister
    {
        public double Totalamount { get; set; }
        public Currency Currency { get; set; }
       
        public Paymenttype Paymenttype { get; set; }
        public static int TotalSalesCount { get; set; }
        public CashRegister(double totalamount, Currency currency)
        {
            Totalamount = totalamount;
            Currency = currency;
           
        }
        public void AddNewSale(double amount,Currency currency1)
        {
            if (currency1==Currency)
            {
                Totalamount += amount;
            }
            else
            {
                switch (currency1)
                {
                    case Currency.USD:
                        amount *= 1.7;
                        break;
                    case Currency.AZN:
                         amount /= 1.7;
                        break;
                    default:
                        break;
                }
            }
            Totalamount += amount;
        }
        public void RemoveNewSale(double amount,Currency currency2)
        {
            if (currency2==Currency)
            {
                Totalamount -= amount;
            }
            else
            {
                switch (currency2)
                {
                    case Currency.USD:
                         amount *= 1.7;
                        break;
                    case Currency.AZN:
                         amount /= 1.7;
                        break;
                    default:
                        break;
                }
            }
            Totalamount -= amount;
        }
        public override string ToString()
        {
            return $"{Totalamount}, {Paymenttype},{Currency}";
        }
    }
}
