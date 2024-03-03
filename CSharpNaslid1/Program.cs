namespace CSharpNaslid1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Phone", 500, 50);
            product1.PrintProductInfo();

            product1.ReducePrice(100, 0);
            product1.PrintProductInfo();

            Product product2 = new Product("Laptop", 1200, 75);
            product2.PrintProductInfo();

            product2.ReducePrice(1500, 0);
            product2.PrintProductInfo();
        }
    }
}
