using System;

namespace Lab4Extra
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
            int i = 1;
            Console.WriteLine("Mata in ett nummer under 100: ");
            int x = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= x);
        }

        private static void LoopTill20()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 20);
            


        }
    }
}
