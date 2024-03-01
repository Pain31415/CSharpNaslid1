using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid1
{
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the President.");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a Security Officer.");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am a Manager.");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am an Engineer.");
        }
    }
}
