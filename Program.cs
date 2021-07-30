using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void PickNumberGreeting()
        {
            Console.WriteLine("Pick a number between 1 and 1024");

        }
        static void CorrectHigherLower()
        {
            Console.WriteLine("Type correct if it is correct, type higher if it is too low, type lower if it is too high");

        }
        static void Main(string[] args)
        {
            var numbers = new List<int>() { };
            for (int number = 1; number <= 1024; number++)
            {
                numbers.Add(number);
            }
            PickNumberGreeting();

            var correctNum = 0;

            string userInput = "";
            while (userInput != "correct")
            {
                Console.WriteLine($"Is this your number: {numbers[correctNum]}");
                CorrectHigherLower();
                userInput = Console.ReadLine();

                if (userInput == "higher")
                {
                    correctNum += 10;
                }

                if (userInput == "lower")
                {
                    correctNum--;
                }
            }
            if (userInput == "correct")
            {
                Console.WriteLine("Nice!");
            }
        }
    }
}