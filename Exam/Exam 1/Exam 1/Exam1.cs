using System;
using System.IO;

class Exam1
{
    static void Main()
    {
        // Prompt the user to input 5 integers
        int[] UserNumbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter integer {i + 1} (between 0 and 100): ");
            UserNumbers[i] = GetValidInput();
        }

        // Calculate sum of user numbers
        int UserSum = 0;
        foreach (int Number in UserNumbers)
        {
            UserSum += Number;
        }

        // Read numbers from file and calculate sum
        string[] lines = File.ReadAllLines("MyNumbers.txt");
        int[] FileNumbers = new int[5];
        for (int i = 0; i < lines.Length; i++)
        {
            FileNumbers[i] = int.Parse(lines[i]);
        }

        int FileSum = 0;
        foreach (int Number in FileNumbers)
        {
            FileSum += Number;
        }

        // Calculate difference
        int Difference = UserSum - FileSum;

        // Write difference to file
        File.WriteAllText("Difference.txt", Difference.ToString());

        // Display results
        Console.WriteLine($"The difference between {UserSum} and {FileSum} is {Difference}.");
    }

    // Function to get valid integer input from user
    static int GetValidInput()
    {
        int Number;
        while (!int.TryParse(Console.ReadLine(), out Number) || Number < 0 || Number > 100)
        {
            Console.Write("Please enter a valid integer between 0 and 100: ");
        }
        return Number;
    }
}
