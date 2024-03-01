using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;

namespace AnimalLibrary
{
    public class Tiger : Animal
    {
        public string Type { get; set; }

        public Tiger(string name, string type) : base(name)
        {
            Type = type;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }
}
