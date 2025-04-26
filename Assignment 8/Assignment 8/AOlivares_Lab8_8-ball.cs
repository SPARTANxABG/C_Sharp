using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AOlivares_Lab8
{
    class Magic_8Ball
    {
        static void Main(string[] args)
        {
            bool continueLoop = true; // Flag to control the loop

            Console.WriteLine("I am the Magic 8-Ball! Ask me a question and I will give you an answer!");

            while (continueLoop)
            {
                Console.WriteLine("What is your question?");
                string question = Console.ReadLine();

                // Create an instance of Random class
                Random rnd = new Random();

                // Generate a random number between 1 and 5
                int roll = rnd.Next(1, 5);

                // Depending on the value of roll, print out different answers
                if (roll == 1)
                {
                    Console.WriteLine("It is certain");
                }
                else if (roll == 2)
                {
                    Console.WriteLine("Reply hazy, try again");
                }
                else if (roll == 3)
                {
                    Console.WriteLine("Don't count on it");
                }
                else if (roll == 4)
                {
                    Console.WriteLine("Signs point to yes");
                }
                else
                {
                    Console.WriteLine("My sources say no");
                }

                // Ask if the user wants to continue
                Console.WriteLine("Would you like to ask another question? (yes/no)");
                string answer = Console.ReadLine();

                // Check the user's answer to decide whether to continue or not
                if (answer.ToLower() != "yes")
                {
                    continueLoop = false; // Set the flag to false to exit the loop
                }
            }
        }
    }
}