namespace CSharpNaslid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota Camry", 2022);
            Motorcycle myMotorcycle = new Motorcycle("Honda CBR", 2021);

            Console.WriteLine($"My car is a {myCar.Model} from {myCar.Year}.");
            Console.WriteLine($"My motorcycle is a {myMotorcycle.Model} from {myMotorcycle.Year}.");

            myCar.MakeSound();
            myMotorcycle.MakeSound();
        }
    }
}
