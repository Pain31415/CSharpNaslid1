using System;
using AnimalLibrary;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger("Tiger1", "Bengal");
            tiger.PrintInfo();

            Crocodile crocodile = new Crocodile("Crocodile1", 64);
            crocodile.PrintInfo();

            Kangaroo kangaroo = new Kangaroo("Kangaroo1", "Australia");
            kangaroo.PrintInfo();
        }
    }
}