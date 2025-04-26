using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class AOlivares_Lab7
    {
        static void Main(string[] args)
        {
            // Gather symptoms from the user
            Console.WriteLine("Disclaimer - This should never be used as a real diagnosis tool!\n");
            Console.WriteLine("Welcome to the STC Medical Diagnosis Tool!");
            Console.Write("Do you have a fever? (yes/no): ");
            string feverInput = Console.ReadLine().ToLower();
            bool hasFever = feverInput == "yes";

            // Nested if statements based on the presence of fever
            if (!hasFever)
            {
                Console.Write("Do you have a stuffy nose? (yes/no): ");
                string stuffyNoseInput = Console.ReadLine().ToLower();
                bool hasStuffyNose = stuffyNoseInput == "yes";

                // Diagnose based on stuffy nose
                if (hasStuffyNose)
                {
                    Console.WriteLine("Diagnosis: Head Cold");
                }
                else
                {
                    Console.WriteLine("Diagnosis: Hypochondria");
                }
            }
            else
            {
                Console.Write("Do you have a rash? (yes/no): ");
                string rashInput = Console.ReadLine().ToLower();
                bool hasRash = rashInput == "yes";

                // Diagnose based on presence of rash
                if (hasRash)
                {
                    Console.WriteLine("Diagnosis: Measles");
                }
                else
                {
                    Console.Write("Does your ear hurt? (yes/no): ");
                    string earHurtInput = Console.ReadLine().ToLower();
                    bool hasEarHurt = earHurtInput == "yes";

                    // Diagnose based on ear pain
                    if (hasEarHurt)
                    {
                        Console.WriteLine("Diagnosis: Ear Infection");
                    }
                    else
                    {
                        Console.WriteLine("Diagnosis: Flu");
                    }
                }
            }
        }
    }
}
