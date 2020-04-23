using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            goto start;
            fuck:
            {
                Console.WriteLine("Quitting...");
                Thread.Sleep(3000);
                Environment.Exit(1);
            }
            start:
            Console.WriteLine("Time for some addition");
            Console.WriteLine("gimme number");
            int f = int.Parse(Console.ReadLine());
            if (f == 69)
            {
                {
                    Console.WriteLine("69?");
                    Console.WriteLine("Really?");
                    Thread.Sleep(2000);
                    Console.WriteLine("...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Die.");
                }
                Console.WriteLine("gimme another number");
                int c = int.Parse(Console.ReadLine());
                if (c == 69)
                    if (f == 69)
                    {
                        Console.WriteLine("69?");
                        Console.WriteLine("Seriously?");
                        Thread.Sleep(2000);
                        Console.WriteLine("...Again?");
                        Thread.Sleep(2000);
                        Console.WriteLine("Perish.");
                        goto fuck;
                    }
                if (c != 69)
                {
                    Console.WriteLine(c + f);
                    Console.WriteLine("Fuck you for your time");
                }
            }
            else
                Console.WriteLine("gimme next number");
            int g = int.Parse(Console.ReadLine());
            if (g == 69)
            {
                Console.WriteLine("I'm so done with you");
            }
            else
            {
                Console.WriteLine(g + f);
                Console.WriteLine("Yay Math");
                goto fuck;
            }

        }
    }
}
