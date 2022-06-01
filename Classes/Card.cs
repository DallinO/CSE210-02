using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{
    public class Card
    {
        int index;
        Random rnd = new Random();
        Dictionary<string, int> card;
        public Card(Game game)
        {
            int x = rnd.Next(game.hashList.Count);
            card = new Dictionary<string, int>(){
                {game.hashList[x], game.newDeck[game.hashList[x]]}
                };
            game.hashList.Remove(game.hashList[x]);
        }

        public Dictionary<string, int> GetCard()
        {
            return(card);
        }
    }
}