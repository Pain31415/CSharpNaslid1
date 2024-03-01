using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid1
{
    public class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The violin produces beautiful music.");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The trombone produces deep tones.");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The ukulele sounds cheerful and bright.");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("The cello produces rich and resonant tones.");
        }
    }
}
