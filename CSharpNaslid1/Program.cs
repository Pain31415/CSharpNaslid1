using System;
using ForeignPassportLibrary;
using PassportLibrary;

namespace PassportApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Passport passport = new Passport("John Doe", "USA", "123456789");
            passport.DisplayInfo();

            Console.WriteLine();

            ForeignPassport foreignPassport = new ForeignPassport("Jane Smith", "UK", "987654321", "AB123456");
            foreignPassport.AddVisa("Schengen Visa");
            foreignPassport.AddVisa("US Visa");
            foreignPassport.DisplayInfo();
        }
    }
}