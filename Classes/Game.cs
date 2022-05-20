using System;
using System.Collections.Generic;

namespace CSE210_02.Classes;

public class Game
{
    public static void StartGame()
    {
        Game newDeck = new Deck.CreateDeck();
        for (int x = 0; x <= 52; x++);
        {
            Console.WriteLine(newDeck[x]);
        }

    }
}