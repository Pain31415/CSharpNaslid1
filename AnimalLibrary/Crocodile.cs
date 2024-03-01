using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;

namespace AnimalLibrary
{
    public class Crocodile : Animal
    {
        public int TeethCount { get; set; }

        public Crocodile(string name, int teethCount) : base(name)
        {
            TeethCount = teethCount;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Teeth count: {TeethCount}");
        }
    }
}
