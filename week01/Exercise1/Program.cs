using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name.
        Console.WriteLine("what is your first name? ");
        string first = Console.ReadLine();

        Console.WriteLine("what is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last} ");
    }
}
