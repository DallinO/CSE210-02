using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{

    public class Game
    {
        public Dictionary<string, int> newDeck;
        public List<string> hashList;
        Deck deck = new Deck();
        public Game()
        {
            newDeck = deck.GetDeck();
            hashList = deck.GetHash();
        }
        public void StartGame()
        {
            Card card = new Card(this);
            Dictionary<string, int> newCard = card.GetCard();
            Console.WriteLine(newCard);
        }
   }
}