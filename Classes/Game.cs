using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{

    public class Game
    {
        public void StartGame()
        {
            Deck newDeck = new Deck();
            List<string> test = newDeck.CreateDeck();
            int x = 0;
            for (x = 0; x <= 52; x++) ;
            {
                Console.WriteLine(test[x]);
            }

        }
    }

}