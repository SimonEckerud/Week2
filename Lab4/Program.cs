using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopTill20();
            LoopInput();
        }

        private static void LoopInput()
        {
            int x = 1;
            Console.WriteLine("Skriv int ett tal mindre än 100: ");
            int i =int.Parse(Console.ReadLine());
            while(x <= i)
            {
                Console.WriteLine(x);
                x++;
            }

        }

        private static void LoopTill20()
        {
            int i = 1;
            while(i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
