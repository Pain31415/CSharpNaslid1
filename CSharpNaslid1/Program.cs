using System;
using CSharpLib;

namespace CSharpNaslid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder()
            {
                Name = "John",
                Age = 35,
                Gender = "Male",
                Specialization = "Construction"
            };

            Sailor sailor = new Sailor()
            {
                Name = "Alice",
                Age = 28,
                Gender = "Female",
                ShipName = "Sea Voyager"
            };

            Pilot pilot = new Pilot()
            {
                Name = "Mike",
                Age = 42,
                Gender = "Male",
                AircraftModel = "Boeing 747"
            };

            builder.Introduce();
            builder.Build();

            sailor.Introduce();
            sailor.Sail();

            pilot.Introduce();
            pilot.Fly();
        }
    }

    public class Builder : Human
    {
        public string Specialization { get; set; }

        public void Build()
        {
            Console.WriteLine($"I am {Name}, a {Age} years old builder specialized in {Specialization}.");
        }
    }

    public class Sailor : Human
    {
        public string ShipName { get; set; }

        public void Sail()
        {
            Console.WriteLine($"I am {Name}, a {Age} years old sailor on the ship {ShipName}.");
        }
    }

    public class Pilot : Human
    {
        public string AircraftModel { get; set; }

        public void Fly()
        {
            Console.WriteLine($"I am {Name}, a {Age} years old pilot flying {AircraftModel}.");
        }
    }
}
