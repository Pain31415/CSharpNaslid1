namespace CSharpLib
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old.");
        }
    }
}
