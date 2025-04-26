using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOlivares_Lab10
{
    class AOlivares_Lab10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms for Fibonacci sequence:");
            int n = int.Parse(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;
            int nextNumber;

            Console.WriteLine($"Fibonacci sequence up to {n} terms:");

            if (n >= 1)
                Console.Write($"{firstNumber} ");

            if (n >= 2)
                Console.Write($"{secondNumber} ");

            for (int i = 3; i <= n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write($"{nextNumber} ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }

            Console.WriteLine();
        }
    }
}