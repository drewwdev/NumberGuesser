using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 1024");
            var numbers = new List<int>() { };
            for (int number = 1; number <= 1024; number++)
            {
                numbers.Add(number);
            }
            int halfOfList = numbers.Count / 2;
            Console.WriteLine($"Is {halfOfList} your number?");
            Console.WriteLine("If it is your number, type correct. If it is not your number, type higher or lower");
            var userInput = Console.ReadLine();

            while (userInput != "correct")
            {
                if (userInput == "higher")
                {

                }
                if (userInput == "lower")
                {

                }
            }
            Console.WriteLine("Nice!");
        }
    }
}
