////////////////////////////////////////////////////////////////////
//
// Name: Andres Olivares
// Date: 01/31/2024
// Class: CITP-3310-V01-Survey of Programming Languages
// Semester: Spring 2024
// Instructor's Name: Nicolas Gutierrez
//
// Program Title: AOlivares_Lab2
// Program Description: Assign values to variables of mutiple types that I have declared
//
////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BasicImput
    {
        static void Main(string[] args)
        {
            using (StreamWriter fileStream = new StreamWriter("output.txt"))
            {
                string userName;
                double intValue1 = 80.52, intValue2 = 85, intValue3 = 97;
                double average;

                userName = "Andres";

                average = (intValue1 + intValue2 + intValue3) / 3;

                Console.WriteLine("\nThe average score of {0} is: {1}", userName, average);
            }
        }
    }
}