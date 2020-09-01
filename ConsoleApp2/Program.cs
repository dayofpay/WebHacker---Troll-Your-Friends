using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.AttackWeb();
            Console.WriteLine("Press Key To Exit...");
            Console.ReadKey();
            Functions.WAF(); // SOON //
        }
    }
}
