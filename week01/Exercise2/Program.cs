using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:  ");
            string valueFromUser = Console.ReadLine();

            int x = 5;
            int y = 2;

            if (x > y)
            {
                Console.WriteLine("Greater");
            }
            else if (x < y)
            {
                Console.WriteLine("less");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
