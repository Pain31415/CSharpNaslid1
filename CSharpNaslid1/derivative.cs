using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid1
{
    public class Car : Device
    {
        public Car(string model, int year) : base(model, year)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Car honks.");
        }
    }

    public class Motorcycle : Device
    {
        public Motorcycle(string model, int year) : base(model, year)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Motorcycle revs its engine.");
        }
    }
}
