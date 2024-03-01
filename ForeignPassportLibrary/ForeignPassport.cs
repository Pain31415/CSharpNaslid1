using System;
using System.Collections.Generic;
using PassportLibrary;

namespace ForeignPassportLibrary
{
    public class ForeignPassport : Passport
    {
        public List<string> Visas { get; set; }
        public string PassportSerialNumber { get; set; }

        public ForeignPassport(string fullName, string nationality, string passportNumber, string passportSerialNumber)
            : base(fullName, nationality, passportNumber)
        {
            PassportSerialNumber = passportSerialNumber;
            Visas = new List<string>();
        }

        public void AddVisa(string visa)
        {
            Visas.Add(visa);
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Foreign Passport Information:");
            Console.WriteLine($"Passport Serial Number: {PassportSerialNumber}");
            Console.WriteLine("Visas:");
            foreach (var visa in Visas)
            {
                Console.WriteLine(visa);
            }
        }
    }
}