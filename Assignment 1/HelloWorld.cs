using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");      // This line prints the words "Hello World!" to the screen and includes a newline.
               
            Console.WriteLine("{0} {1} {2}", "Programming", "can be", "fun!");  // This line prints the sentence "Programming can be fun!"
                                                                                // It uses format items, labeled {#}, to build more complicated strings.

            Console.Write("\n\n");                  // Console.Write() does not include a newline automatically. We can use the escape character '\n'
                                                    // to include new lines manually.

            Console.WriteLine("  CCCCCCC    ###    ###     ");      // These lines make use of extra whitespace, which is NOT ignored inside of a string
            Console.WriteLine(" CCCCCCC     ###    ###     ");      // to draw the C# shape you see here.
            Console.WriteLine("CCC       ################  ");
            Console.WriteLine("CC        ################  ");
            Console.WriteLine("CC           ###    ###     ");
            Console.WriteLine("CC        ################  ");
            Console.WriteLine("CCC       ################  ");
            Console.WriteLine(" CCCCCC      ###    ###     ");
            Console.WriteLine("  CCCCCC     ###    ###     ");

        }
    }
}
