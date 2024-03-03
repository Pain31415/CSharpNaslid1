using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
        private int dollars;
        private int cents;

        // Конструктор
        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public void PrintMoney()
        {
            Console.WriteLine($"Total: ${dollars}.{cents:00}");
        }

        public void SetMoney(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }

        public int Cents
        {
            get { return cents; }
            set { cents = value; }
        }
    }
}
