using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNaslid1
{
    public class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }

        public MusicalInstrument(string name, string description, string history)
        {
            Name = name;
            Description = description;
            History = history;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The musical instrument makes a sound.");
        }

        public void Show()
        {
            Console.WriteLine($"Musical instrument: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public void ShowHistory()
        {
            Console.WriteLine($"History: {History}");
        }
    }
}
