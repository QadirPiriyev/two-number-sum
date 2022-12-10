namespace twoNumberSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("zehmet olmasa 1 eded daxil edin");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("zehmet olmasa 1 eded daha daxil edin");
                int b = Convert.ToInt32(Console.ReadLine());
                int cavab = a + b;
                Console.WriteLine("bu ededlerin cemi: " + cavab);
            }

        }
    }
}