using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOlivares_Lab8
{
    class AOlivares_Lab8_NumGuess
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Generate a random number between 1 and 100
            int guesses = 0;
            int maxGuesses = 5;
            bool guessedCorrectly = false;

            Console.WriteLine("Welcome to the STC Number Guesser game!");
            Console.WriteLine("I've selected a number between 1 and 100. Try to guess it!");

            while (!guessedCorrectly && guesses < maxGuesses)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    guesses++;

                    if (guess == secretNumber)
                    {
                        guessedCorrectly = true;
                        Console.WriteLine("Congratulations! You've guessed the correct number!");
                    }
                    else
                    {
                        Console.WriteLine($"Wrong guess! You have {maxGuesses - guesses} guesses left.");
                        if (guess < secretNumber)
                        {
                            Console.WriteLine("Try guessing higher.");
                        }
                        else
                        {
                            Console.WriteLine("Try guessing lower.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            if (!guessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've run out of guesses. The correct number was {secretNumber}.");
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}