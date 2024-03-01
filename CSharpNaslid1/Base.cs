using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid1
{
    public class Device
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Device(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Device makes a sound.");
        }
    }
}
