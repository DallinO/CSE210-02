using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{

    public class Game
    {
        Deck deck = new Deck();
        public Dictionary<string, int> newDeck;
        public Game()
        {
            newDeck = deck.GetDeck();
        }
        public Dictionary<string, int> GiveDeck()
        {
            return(newDeck);
        }
        public void StartGame()
        {
            int points = 300;

            /* foreach (KeyValuePair<string, int> key in newDeck)
            {
                Console.WriteLine($"{newDeck.Key}, {newDeck.Value}");
            }
            
            while (points > 0)
            {

                Card card = new Card();
                card = Card.GetCard();
                Console.WriteLine($"The Card is: {firstCard}");

                Console.Write("Higher or Lower (H/L)? ");
                Console.WriteLine($"The next card is: {nextCard}");
                Console.WriteLine(startingCardValue);
                Console.WriteLine(nextCardValue);

                if (startingCardValue < nextCardValue)
                {
                    if (guess == "H")
                    {
                        points = points + 100;
                    }
                    else
                    {
                        points = points - 75;
                    }
                }
                if (startingCardValue > nextCardValue)
                {
                    if (guess == "L")
                    {
                        points = points + 100;
                    }
                    else
                    {
                        points = points - 75;
                    }
                }

                Console.WriteLine($"Your score is {points}");
                Console.Write("Play again (Y/N)? ");
                string repeat = Console.ReadLine();

                if (repeat == "N")
                {
                    Environment.Exit(0);
                }
                if (points == 0)
                {
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                }
                if (deck.Count == 0)
                {
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);
                }
            }*/
        }
   }
}