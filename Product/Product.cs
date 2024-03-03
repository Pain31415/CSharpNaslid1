using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, int dollars, int cents)
        {
            this.name = name;
            this.price = new Money(dollars, cents);
        }

        public void ReducePrice(int dollars, int cents)
        {
            int totalCents = price.Dollars * 100 + price.Cents;
            int reduction = dollars * 100 + cents;
            totalCents -= reduction;

            if (totalCents < 0)
            {
                Console.WriteLine("Error: Price cannot be negative.");
                return;
            }

            price.Dollars = totalCents / 100;
            price.Cents = totalCents % 100;
        }

        public void PrintProductInfo()
        {
            Console.Write($"Product: {name}, Price: ");
            price.PrintMoney();
        }
    }
}
