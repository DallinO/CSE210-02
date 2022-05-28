using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{
    public class Card
    {
        int index;
        Random rnd = new Random();
        // Dictionary<string, int> card;
        public Dictionary<string, int> NewCard(Deck deck)
        {
            deck.suite.Add("Test");

            return(deck.suite);
        }
    }
}