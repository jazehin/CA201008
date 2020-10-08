using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA201008
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Hello((ConsoleColor)rnd.Next(1,16));
            }
            
            Kilepes();
        }

        static void Hello(ConsoleColor szin)
        {
            Console.ForegroundColor = szin;
            Console.WriteLine("Hello World");
            Console.ResetColor();
        }

        static void Kilepes()
        {
            Console.Write("Nyomja meg az ESC-t...");
            ConsoleKey c;
            do
            {
                c = Console.ReadKey(true).Key;
            } while (c != ConsoleKey.Escape);
            Console.Clear();
            for (int i = 3; i >= 1; i--)
            {
                Console.Write(i);
                for (int j = 1; j < 4; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
            }
            Console.WriteLine("Viszlát");
            Thread.Sleep(2000);
        }
    }
}
