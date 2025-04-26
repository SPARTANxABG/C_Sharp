using System;

class AOlivares_Lab6
{
    static void Main(string[] args)
    {
        // Gather symptoms from the user
        Console.WriteLine("Disclaimer - This should never be used as a real diagnosis tool!\n");
        Console.WriteLine("Welcome to the STC Medical Diagnosis Tool!");
        Console.WriteLine("Please answer the following questions:");
        Console.Write("Do you have a fever? (yes/no): ");
        string feverInput = Console.ReadLine().ToLower();
        bool hasFever = feverInput == "yes";

        Console.Write("Do you have a stuffy nose? (yes/no): ");
        string stuffyNoseInput = Console.ReadLine().ToLower();
        bool hasStuffyNose = stuffyNoseInput == "yes";

        Console.Write("Does your ear hurt? (yes/no): ");
        string earHurtInput = Console.ReadLine().ToLower();
        bool hasEarHurt = earHurtInput == "yes";

        Console.Write("Do you have a rash? (yes/no): ");
        string rashInput = Console.ReadLine().ToLower();
        bool hasRash = rashInput == "yes";

        // Diagnose the condition
        string diagnosis = "";

        if (!hasFever && !hasStuffyNose)
        {
            diagnosis = "Hypochondria";
        }
        else if (!hasFever && hasStuffyNose)
        {
            diagnosis = "Head Cold";
        }
        else if (hasFever && !hasRash && hasEarHurt)
        {
            diagnosis = "Ear Infection";
        }
        else if (hasFever && !hasRash && !hasEarHurt)
        {
            diagnosis = "Flu";
        }
        else if (hasFever && hasRash)
        {
            diagnosis = "Measles";
        }

        // Output the diagnosis
        Console.WriteLine($"Based on your symptoms, the diagnosis is: {diagnosis}");
    }
}