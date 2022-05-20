using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{


    public class Deck
    {
        public List<string> CreateDeck()
        {
            List<string> suite = new List<string>();
            suite.Add("Heart");
            suite.Add("Spade");
            suite.Add("Diamond");
            suite.Add("Club");

            List<string> deckLiteral = new List<string>();
            List<int> deckNumerical = new List<int>();
            for (int x = 1; x <= 4; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    deckLiteral.Add(y + " " + suite[x]);
                }
                deckLiteral.Add("J " + suite[x]);
                deckLiteral.Add("Q " + suite[x]);
                deckLiteral.Add("K " + suite[x]);
                deckLiteral.Add("A " + suite[x]);

                int zeda = 1;
                for (zeda = 1; zeda <= 13; zeda++);
                {
                    deckNumerical.Add(zeda);
                }

            }

            return (deckLiteral);
        }
    }
}