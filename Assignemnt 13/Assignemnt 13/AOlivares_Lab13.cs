using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame
{
    class warGame
    {
        // GLOBAL CONSTANTS
        const int SIZE = 10;    // This constant sets the size of our "deck"
                                // Increasing it will cause your program to 
                                // take longer to reach a conclusion.


        static void Main(string[] args)
        {
            int[] deck = new int[SIZE];     // The deck of cards
            int[] hand_one = new int[SIZE]; // A hand of cards, with all elements initialized to zero
            int[] hand_two = new int[SIZE]; // A hand of cards, with all elements initialized to zero
            int tmp1;                       // Temporary variable to hold a card
            int tmp2;                       // Temporary variable to hold a card
            int size1 = SIZE / 2;           // Number of cards in hand 1
            int size2 = SIZE / 2;           // Number of cards in hand 2
            string tmpStr;                  // Used for asking the user to press enter to continue            

            // Get a deck of numbers (to represent cards)
            // Because we are simulating a deck of cards, we will get random numbers
            // in the range of 1 to 13.
            getNums(deck, 13, SIZE);

            // Deal the deck between the two players
            splitArray(hand_one, hand_two, deck, SIZE);

            //loop until one player has no more cards.
            while (size1 != 0 && size2 != 0)
            {
                // Show the card at the front of each players hand
                showCard(hand_one, hand_two, size1, size2);

                // Store the front cards into temporary variables
                tmp1 = hand_one[0];
                tmp2 = hand_two[0];

                // Shift the cards forward in each hand
                shift(hand_one, size1);
                shift(hand_two, size2);

                // If the first player has the higher card 
                if (tmp1 > tmp2)
                {
                    Console.WriteLine("You have the higher card!");

                    // We are going to add one card to Player 1's hand and
                    // remove a card from Player 2's hand. So increase the size
                    // of the Player 1 array and decrease the size of the
                    // Player 2 array by one.
                    size1++;
                    size2--;

                    //add both cards to the end of Player 1's hand
                    hand_one[size1 - 2] = tmp1;
                    hand_one[size1 - 1] = tmp2;

                }

                // If the computer has the higher card
                else if (tmp2 > tmp1)
                {
                    Console.WriteLine("The computer has the higher card!");

                    // We are going to add one card to Player 2's hand and
                    // remove a card from Player 1's hand. So increase the size
                    // of the Player 2 array and decrease the size of the
                    // Player 1 array by one.
                    size1--;
                    size2++;

                    // Add both cards to the end of Player 2's hand
                    hand_two[size2 - 2] = tmp2;
                    hand_two[size2 - 1] = tmp1;

                }

                // If both players have the same value card
                else
                {
                    Console.WriteLine("Tie!");
                    // Don't change the size of the players' hands

                    // Put each player's card at the end of their hand
                    hand_one[size1 - 1] = tmp1;
                    hand_two[size2 - 1] = tmp2;

                }

                // Pause the game at the end of each turn
                Console.Write("Press any key for the next turn...");
                Console.ReadKey();

                Console.Write("\n");
            }

            // Output the winner of the game
            if (size1 == 0)
            {
                Console.WriteLine("The computer wins the game!");
            }
            else if (size2 == 0)
            {
                Console.WriteLine("You win the game!");
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        } // end Main function



        //
        // Generate random numbers in the range between one and the given range
        // to fill an array
        //
        // DO NOT MODIFY THIS FUNCTION
        //
        static void getNums(int[] arr, int range, int size)
        {
            int i;                      // A loop control variable
            Random rnd = new Random();

            for (i = 0; i < size; i++)
            {
                // Add a random number within the specified range to the array
                arr[i] = rnd.Next(1, 7);
            }
        }



        //
        // Display the cards each player pulled and the number of cards they have left
        //
        // DO NOT MODIFY THIS FUNCTION
        //
        static void showCard(int[] hand_one, int[] hand_two, int one, int two)
        {
            Console.WriteLine("*****Number of cards in each player's deck*****\n");
            Console.WriteLine("You: {0}", one);
            Console.WriteLine("Computer: {0}", two);
            Console.WriteLine("You have the card: {0}", hand_one[0]);
            Console.WriteLine("The computer has the card: {0}", hand_two[0]);
        }


        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////
        ////																		 ////
        ////					YOUR CODE GOES BELOW THIS POINT						 ////
        ////																		 ////
        /////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////


        //
        // Split the elements of a source array into two destination arrays
        // The given size is the size of the destination arrays (they are the same size)
        //
        // WRITE CODE TO COMPLETE THIS FUNCTION
        //
        static void splitArray(int[] dest_one, int[] dest_two, int[] source, int size)
        {
            int ctr = 0; //Counter that will go through the source[] array.
            int i;       // A counter for our loop control variable

            // Loop through the destination arrays.
            // Assign each element in a destination array the next element
            // in the source array. Use the ctr variable to keep track of the
            // current position in the source array.
            for (i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                    dest_one[i / 2] = source[i]; // Deal to destination array one
                else
                    dest_two[i / 2] = source[i]; // Deal to destination array two
            }
        }

        //
        // Shifts the items in an array one place to the left
        // Throws out the first element in the array and sets the last element
        // in the array to zero.
        //
        // WRITE CODE TO COMPLETE THIS FUNCTION
        //
        static void shift(int[] arr, int size)
        {
            int i; // A counter

            // shift the array
            for (i = 0; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            // Set the last element in the array to zero
            arr[size - 1] = 0;

        }

    } // end Class

} // end Namespace