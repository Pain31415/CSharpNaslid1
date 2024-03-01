namespace PassportLibrary
{
    public class Passport
    {
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }

        public Passport(string fullName, string nationality, string passportNumber)
        {
            FullName = fullName;
            Nationality = nationality;
            PassportNumber = passportNumber;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Passport Information:");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Nationality: {Nationality}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
        }
    }
}
