using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackGame
{
    class Jackblack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blackjack!");

            while (true)
            {
                // Initialize the deck and players
                Deck deck = new Deck();
                deck.Initialize();
                Player player = new Player();
                Player dealer = new Player();

                // Deal initial cards
                player.AddCard(deck.DrawCard());
                dealer.AddCard(deck.DrawCard());
                player.AddCard(deck.DrawCard());
                dealer.AddCard(deck.DrawCard());

                // Display initial hands
                Console.WriteLine("Your hand:");
                player.ShowHand();
                Console.WriteLine($"Your Total: {player.GetHandValue()}\n");

                Console.WriteLine("Dealer's hand:");
                dealer.ShowHand();
                Console.WriteLine($"Dealer's Total: {dealer.GetHandValue()}\n");

                // Player's turn
                while (true)
                {
                    Console.WriteLine("Do you want to hit or stand? (h/s)");
                    char choice = Char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();

                    if (choice == 'h')
                    {
                        player.AddCard(deck.DrawCard());
                        Console.WriteLine("Your hand:");
                        player.ShowHand();
                        Console.WriteLine($"Your Total: {player.GetHandValue()}\n");

                        if (player.GetHandValue() > 21)
                        {
                            Console.WriteLine("You bust! Dealer wins.\n");
                            break;
                        }
                    }
                    else if (choice == 's')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'h' or 's'.");
                    }
                }

                if (player.GetHandValue() <= 21)
                {
                    // Dealer's turn
                    Console.WriteLine("Dealer's turn:");
                    dealer.ShowHand();
                    Console.WriteLine($"Dealer's Total: {dealer.GetHandValue()}\n");

                    while (dealer.GetHandValue() < 17)
                    {
                        dealer.AddCard(deck.DrawCard());
                        dealer.ShowHand();
                        Console.WriteLine($"Dealer's Total: {dealer.GetHandValue()}\n");
                    }

                    if (dealer.GetHandValue() > 21 || dealer.GetHandValue() < player.GetHandValue())
                    {
                        Console.WriteLine("You win!\n");
                    }
                    else if (dealer.GetHandValue() > player.GetHandValue())
                    {
                        Console.WriteLine("Dealer wins.\n");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!\n");
                    }
                }

                Console.WriteLine("Do you want to play again? (y/n)");
                char playAgain = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (playAgain != 'y')
                {
                    break;
                }
            }
        }
    }

    class Card
    {
        public string Suit { get; set; }
        public string FaceValue { get; set; }
        public int Value { get; set; }
    }

    class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
        }

        public void Initialize()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] faceValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (string suit in suits)
            {
                foreach (string faceValue in faceValues)
                {
                    int value = (faceValue == "Jack" || faceValue == "Queen" || faceValue == "King") ? 10 :
                                (faceValue == "Ace") ? 11 : int.Parse(faceValue);
                    cards.Add(new Card { Suit = suit, FaceValue = faceValue, Value = value });
                }
            }
        }

        public Card DrawCard()
        {
            Random random = new Random();
            int index = random.Next(cards.Count);
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }
    }

    class Player
    {
        private List<Card> hand;

        public Player()
        {
            hand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public int GetHandValue()
        {
            int value = 0;
            int numAces = 0;

            foreach (Card card in hand)
            {
                value += card.Value;
                if (card.FaceValue == "Ace")
                {
                    numAces++;
                }
            }

            // Adjust value for Aces
            while (value > 21 && numAces > 0)
            {
                value -= 10;
                numAces--;
            }

            return value;
        }

        public void ShowHand()
        {
            foreach (Card card in hand)
            {
                Console.WriteLine($"{card.FaceValue} of {card.Suit}");
            }
        }
    }
}
