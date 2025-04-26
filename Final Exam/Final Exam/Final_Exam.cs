using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamProject
{
    // Class representing a student with a grade
    class Student
    {
        public int Grade { get; set; }
    }

    class FinalExam
    {
        static void Main(string[] args)
        {
            // Calling the GetDataFromFile function to read data from the input file into an array
            Student[] students = GetDataFromFile("input.txt");

            // Calling the CalcResults function to calculate lowest, highest, and average grades
            CalcResults(students, out int lowest, out int highest, out double average);

            // Calling the DisplayGradeDistribution function to display results
            DisplayGradeDistribution(students, lowest, highest, average);
        }

        // Function to read file contents into array of Student objects
        // Parameters: filename (string) - name of the input file
        // Return type: Student[] - array of Student objects containing grades
        static Student[] GetDataFromFile(string filename)
        {
            // Check if the file exists
            if (!File.Exists(filename))
            {
                Console.WriteLine("Input file not found.");
                Environment.Exit(1); // Exit program if file not found
            }

            string[] lines = File.ReadAllLines(filename);
            Student[] students = new Student[lines.Length];

            // Parse each line of the file and store grades in the Student array
            for (int i = 0; i < lines.Length; i++)
            {
                students[i] = new Student();
                students[i].Grade = int.Parse(lines[i]);
            }

            return students;
        }

        // Function to calculate lowest, highest, and average grades
        // Parameters: students (Student[]) - array of Student objects containing grades
        //             lowest (out int) - lowest grade
        //             highest (out int) - highest grade
        //             average (out double) - average grade
        // Return type: void
        static void CalcResults(Student[] students, out int lowest, out int highest, out double average)
        {
            lowest = int.MaxValue;
            highest = int.MinValue;
            int sum = 0;

            // Iterate through the array to find lowest, highest, and calculate sum
            foreach (var student in students)
            {
                if (student.Grade < lowest)
                    lowest = student.Grade;
                if (student.Grade > highest)
                    highest = student.Grade;
                sum += student.Grade;
            }

            average = (double)sum / students.Length;
        }

        // Function to determine grade distribution and display results
        // Parameters: students (Student[]) - array of Student objects containing grades
        //             lowest (int) - lowest grade
        //             highest (int) - highest grade
        //             average (double) - average grade
        // Return type: void
        static void DisplayGradeDistribution(Student[] students, int lowest, int highest, double average)
        {
            // Initialize array to store grade distribution count
            int[] gradeDistribution = new int[5]; // Five grade ranges: 0-59, 60-69, 70-79, 80-89, 90-100

            // Count the occurrences of each grade range
            foreach (var student in students)
            {
                if (student.Grade >= 0 && student.Grade <= 59)
                {
                    gradeDistribution[0]++;
                }
                else if (student.Grade >= 60 && student.Grade <= 69)
                {
                    gradeDistribution[1]++;
                }
                else if (student.Grade >= 70 && student.Grade <= 79)
                {
                    gradeDistribution[2]++;
                }
                else if (student.Grade >= 80 && student.Grade <= 89)
                {
                    gradeDistribution[3]++;
                }
                else if (student.Grade >= 90 && student.Grade <= 100)
                {
                    gradeDistribution[4]++;
                }
            }

            // Display results
            Console.WriteLine($"Lowest grade: {lowest}");
            Console.WriteLine($"Highest grade: {highest}");
            Console.WriteLine($"Average grade: {average:F2}");

            Console.WriteLine("\nGrade Distribution:");
            Console.WriteLine("0-59: " + gradeDistribution[0] + " students");
            Console.WriteLine("60-69: " + gradeDistribution[1] + " students");
            Console.WriteLine("70-79: " + gradeDistribution[2] + " students");
            Console.WriteLine("80-89: " + gradeDistribution[3] + " students");
            Console.WriteLine("90-100: " + gradeDistribution[4] + " students");
        }
    }
}
