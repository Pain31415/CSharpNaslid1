namespace CSharpNaslid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Violin", "A string instrument with four strings.", "The violin has a long history dating back to the early 16th century.");
            Trombone trombone = new Trombone("Trombone", "A brass instrument with a slide mechanism.", "The trombone evolved from the medieval trumpet in the 15th century.");
            Ukulele ukulele = new Ukulele("Ukulele", "A small guitar-like instrument with four strings.", "The ukulele originated in the 19th century as a Hawaiian adaptation of the Portuguese machete.");
            Cello cello = new Cello("Cello", "A large string instrument played with a bow.", "The cello has a history dating back to the 16th century, evolving from earlier stringed instruments.");

            violin.Show();
            violin.Desc();
            violin.ShowHistory();
            violin.MakeSound();

            Console.WriteLine();

            trombone.Show();
            trombone.Desc();
            trombone.ShowHistory();
            trombone.MakeSound();

            Console.WriteLine();

            ukulele.Show();
            ukulele.Desc();
            ukulele.ShowHistory();
            ukulele.MakeSound();

            Console.WriteLine();

            cello.Show();
            cello.Desc();
            cello.ShowHistory();
            cello.MakeSound();
        }
    }
}
