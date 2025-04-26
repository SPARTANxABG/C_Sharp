using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BasicInput
    {
        static void Main(string[] args)
        {
            string userName;            // Creates a variable to hold a string, often used for a single word or phrase.
            int intValue1, intValue2;   // These variables will hold two integer values.
			double decimalValue;		// This variable will hold a decimal value.
            double product;                // This variable will store the product of the previous two integers.
            int remainder;              // This variable will store the remainder, or modulus, of the previous two integers.

			userName = "Casey Moore";	// This assignment statement assigns the string literal value "Casey Moore" to be stored in the variable userName.
										// userName was declared to be of type string, so this is a valid assignment statement.
	
			intValue1 = 20;		// This assignment statement assigns the integer literal value 20 to be stored in location value1, which is of type int.
			intValue2 = 7;		// Similar to the above statement. The int type stores whole numbers, with no decimal component.
		
			decimalValue = 2.5;	// Assigns the decimal value 2.5 to the variable decimalValue. Variables of type double CAN store numbers with decimal places.
			
			product = decimalValue * intValue1;    	// Calculate the product of the two numbers and store the result in product.
            remainder = intValue1 % intValue2;  	// Calculate the remainder, or modulus, of the two numbers.

            Console.WriteLine("\nThe product of {0} and {1} is {2}", decimalValue, intValue1, product);            // These lines use formatting to output
            Console.WriteLine("\nThe remainder of {0} divided by {1} is {2}", intValue1, intValue2, remainder);    // the values of the numbers and the result
                                                                                                                   // of both operations.

            Console.Write("Press any key to continue.  .  .");		// These two lines manually put in a pause at the end of the execution of your program.
            Console.ReadKey();
        }
    }
}
