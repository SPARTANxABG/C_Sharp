using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOlivares_Lab9
{
    class AOlivares_Lab9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word you want to search for:");

            string wordToSearch = Console.ReadLine();

            bool found = false;

            // Open the dictionary file for reading
            using (StreamReader sr = new StreamReader("dictionary.txt"))
            {
                string line;

                // Continue reading lines until the end of the file (EOF)
                while ((line = sr.ReadLine()) != null)
                {
                    // Check if the current line contains the word
                    if (line.Contains(wordToSearch))
                    {
                        found = true;
                        break; // Exit the loop since the word is found
                    }
                }
            }

            // Display the result to the user
            if (found)
            {
                Console.WriteLine($"The word '{wordToSearch}' was found in the dictionary.");
            }
            else
            {
                Console.WriteLine($"The word '{wordToSearch}' was not found in the dictionary.");
            }
        }
    }
}