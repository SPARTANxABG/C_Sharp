////////////////////////////////////////////////////////////////////
//
// Name: Andres Olivares
// Date: 01/27/2024
// Class: CITP-3310-V01-Survey of Programming Languages
// Semester: Spring 2024
// Instructor's Name: Nicolas Gutierrez
//
// Program Title: AOlivares_Lab1
// Program Description: Use console.writeline() to output a command
//
////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            Console.WriteLine("My name is Andres Olivares.");      // This line prints the words "Hello World!" to the screen and includes a newline.

            Console.WriteLine("{0}     {1}      {2}", "This", "is", "Lab 1.");  // This line prints the sentence "Programming can be fun!"
                                                                                // It uses format items, labeled {#}, to build more complicated strings.

            Console.Write("\n\n");                  // Console.Write() does not include a newline automatically. We can use the escape character '\n'
                                                    // to include new lines manually.

            Console.WriteLine("               AAA                         OOOOOOOOO     ");      // These lines make use of extra whitespace, which is NOT ignored inside of a string
            Console.WriteLine("              AAAAA                      OOOOOOOOOOOOO   ");      // to draw the C# shape you see here.
            Console.WriteLine("             AAAAAAA                   OOOOOOOOOOOOOOOOO ");
            Console.WriteLine("            AAAAAAAAA                 OOOOOOOOOOOOOOOOOOO");
            Console.WriteLine("           AAAAAAAAAAA                OOOOOOOO   OOOOOOOO");
            Console.WriteLine("          AAAAAAAAAAAAA               OOOOOOO     OOOOOOO");
            Console.WriteLine("         AAAAAAA AAAAAAA              OOOOOOO     OOOOOOO");
            Console.WriteLine("        AAAAAAA   AAAAAAA             OOOOOOO     OOOOOOO");
            Console.WriteLine("       AAAAAAA     AAAAAAA            OOOOOOO     OOOOOOO");
            Console.WriteLine("      AAAAAAAAAAAAAAAAAAAAA           OOOOOOO     OOOOOOO");
            Console.WriteLine("     AAAAAAAAAAAAAAAAAAAAAAA          OOOOOOO     OOOOOOO");
            Console.WriteLine("    AAAAAAAAAAAAAAAAAAAAAAAAA         OOOOOOOO   OOOOOOOO");
            Console.WriteLine("   AAAAAAA             AAAAAAA        OOOOOOOOOOOOOOOOOOO");
            Console.WriteLine("  AAAAAAA               AAAAAAA        OOOOOOOOOOOOOOOOO ");
            Console.WriteLine(" AAAAAAA                 AAAAAAA         OOOOOOOOOOOOO   ");
            Console.WriteLine("AAAAAAA                   AAAAAAA          OOOOOOOOO     ");

        }
    }
}
