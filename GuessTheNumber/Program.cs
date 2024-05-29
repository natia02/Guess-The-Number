using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            // Display the rules of the game
            PrintGameRules();

            // Get the minimum and maximum range from the user
            int minRange = GetValidInteger("Enter the minimum value of the range: ");
            int maxRange = GetValidInteger("Enter the maximum value of the range: ");

            // Ensure minRange is less than maxRange
            while (minRange >= maxRange)
            {
                Console.WriteLine("The minimum value must be less than the maximum value. Please re-enter the range.");
                minRange = GetValidInteger("Enter the minimum value of the range: ");
                maxRange = GetValidInteger("Enter the maximum value of the range: ");
            }

            Console.WriteLine($"You have set the range from {minRange} to {maxRange}.");

            // Start guessing process
            PerformGuessing(minRange, maxRange);
        }

        static void PrintGameRules()
        {
            Console.WriteLine("Welcome to the game 'Guess The Number!'");
            Console.WriteLine("Rules:");
            Console.WriteLine("1. Think of a number.");
            Console.WriteLine("2. Enter the minimum and maximum range for the program to guess within.");
            Console.WriteLine("3. The program will guess a number, and you will respond with '>', '<', or 'Yes'.");
            Console.WriteLine("4. '>' means your number is higher, '<' means your number is lower, 'Yes' means the program guessed correctly.");
            Console.WriteLine("Let's get started!\n");
        }

        static int GetValidInteger(string prompt)
        {
            int result;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine() ?? string.Empty, out result))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write(prompt);
            }
            return result;
        }

        static void PerformGuessing(int minRange, int maxRange)
        {   
            int originalMinRange = minRange;
            int originalMaxRange = maxRange;
            bool correctGuess = false;
            while (!correctGuess)
            {
                int guess = (minRange + maxRange) / 2;

                if (guess < originalMinRange || guess > originalMaxRange)
                {
                    Console.WriteLine($"You said your number was in range of {originalMinRange} - {originalMaxRange}");
                    Console.WriteLine("YOU LIED TO ME! GAME IS OVER!!!");
                    return;
                }
                Console.WriteLine($"Is your number {guess}? (respond with '>', '<', or 'Yes'):");
                string response = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

                switch (response)
                {
                    case "yes":
                        Console.WriteLine("Great! The program guessed your number correctly.");
                        correctGuess = true;
                        Console.WriteLine("Thank you for playing 'Guess The Number!'");
                        break;
                    case ">":
                        minRange = guess + 1;
                        break;
                    case "<":
                        maxRange = guess - 1;
                        break;
                    default:
                        Console.WriteLine("Invalid response. Please respond with '>', '<', or 'Yes'.");
                        break;
                }
            }
        }
    }
}