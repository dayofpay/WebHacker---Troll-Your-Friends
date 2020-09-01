using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp2
{
    public class Functions
    {
        public static void AttackWeb()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("WebSite/s: ");
            var websites = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[!] ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Write("[!] Your Username:");
            var username = Console.ReadLine();
            Console.Write("Threads: ");
            var tim = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tim; i++)
            {
                int hacked = 0;
                Console.Title = "WebHacker: Total Threads: " + i + " " + "Fails: " + i + " " + "Success: " + hacked;
                System.Threading.Thread.Sleep(0055);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" // FAIL //" + " (#{0})", i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" // ATTACKING // ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" // {0} // ", websites);
                Console.ForegroundColor = ConsoleColor.Yellow;
                string protection = "True";
                string useradmin = "root@";
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" // STATUS: Connected //");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" // Protection: {0} // ", protection);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" // {0}{1} //", useradmin, username);
            }
            for (int i2 = 1; i2 <= 3; i2++)
            {
                Console.Clear();
                int hacked2 = 1;
                Console.Title = "WebHacker: Total Threads: " + i2 + " " + "Fails: " + i2 + " " + "Success: " + hacked2;
                System.Threading.Thread.Sleep(0055);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" // SUCCESS //");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" // ATTACKING // ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" // {0} // ", websites);
                Console.ForegroundColor = ConsoleColor.Yellow;
                string protection2 = "True";
                string useradmin2 = "root@";
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" // STATUS: Connected //");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" // Protection: {0} // ", protection2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" // {0}{1} //", useradmin2, username);
            }
        }
        public static void WAF()
        {
            return;
        }
    }
}