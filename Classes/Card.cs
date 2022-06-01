using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{
    public class Card
    {
        int index;
        Random rnd = new Random();
        string card;
        public Card(Game game)
        {
            int x = rnd.Next(game.hashList.Count);
            card = game.hashList[x];
            game.hashList.Remove(game.hashList[x]);
        }

        public string GetCard()
        {
            return(card);
        }
    }
}