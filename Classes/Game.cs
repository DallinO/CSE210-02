using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{

    public class Game
    {
        public void StartGame()
        {
            Deck newDeck = new Deck();
            List<string> deck = newDeck.CreateDeck();
            List<int> location = newDeck.CreateHierarchy();
            int points = 300;

            for (int a = 0; a < 52; a++)
            {
                Console.WriteLine(deck[a]);
                Console.WriteLine(location[a]);
            }

            Random rnd = new Random();

            while (points > 0)
            {
                int cardPosition = rnd.Next(deck.Count); 
                string startingCard = deck[cardPosition];
                int startingCardValue = location[cardPosition];

                Console.WriteLine($"The Card is: {startingCard}");
                deck.Remove(deck[cardPosition]);
                location.Remove(location[cardPosition]);

                cardPosition = rnd.Next(deck.Count);
                string nextCard = deck[cardPosition];
                int nextCardValue = location[cardPosition];

                Console.Write("Higher or Lower (H/L)? ");
                string guess = Console.ReadLine();

                Console.WriteLine($"The next card is: {nextCard}");
                deck.Remove(deck[cardPosition]);
                location.Remove(location[cardPosition]);

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
            }
        }
   }
}