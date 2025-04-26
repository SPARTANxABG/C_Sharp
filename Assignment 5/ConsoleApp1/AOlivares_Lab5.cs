using System;


namespace AOlivares_Lab5
{
    class Magic_8Ball
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the Magic 8-Ball! Ask me a question and I will give you an answer:");
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
        }
    }
}
