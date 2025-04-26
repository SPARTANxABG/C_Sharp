using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_in_and_out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for registering!\nPlease enter the following information:\nFull Name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Gender (M/F): ");
            char gender = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter("userdata.txt"))
            {
                writer.WriteLine("name: " + name);
                writer.WriteLine("Gender: " + gender);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Salary: " + salary);
            }

            Console.WriteLine("Saving data complete!");

            Console.WriteLine("Test Read: ");

            using (StreamReader reader = new StreamReader("userdata.txt"))
            {
                string savedName = reader.ReadLine().Split(':')[1].Trim();
                char savedGender = char.Parse(reader.ReadLine().Split(':')[1].Trim());
                int savedAge = int.Parse(reader.ReadLine().Split(':')[1].Trim());
                double savedSalary = double.Parse(reader.ReadLine().Split(':')[1].Trim());

                Console.WriteLine("\nRead data:");
                Console.WriteLine("Name: " + savedName);
                Console.WriteLine("Gender: " + savedGender);
                Console.WriteLine("Age: " + savedAge);
                Console.WriteLine("Salary: " + savedSalary);
            }
        }
    }
}