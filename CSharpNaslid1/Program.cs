namespace CSharpNaslid1
{
    class Program
    {
        static void Main(string[] args)
        {
            President president = new President();
            Security security = new Security();
            Manager manager = new Manager();
            Engineer engineer = new Engineer();

            president.Print();
            security.Print();
            manager.Print();
            engineer.Print();
        }
    }
}
