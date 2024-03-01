using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;

namespace AnimalLibrary
{
    public class Kangaroo : Animal
    {
        public string Habitat { get; set; }

        public Kangaroo(string name, string habitat) : base(name)
        {
            Habitat = habitat;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Habitat: {Habitat}");
        }
    }
}
