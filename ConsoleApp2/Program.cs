using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.AttackWeb();
            Console.ReadKey();
            Console.WriteLine("Press Key To Exit...");
            Functions.WAF();
        }
    }
}
