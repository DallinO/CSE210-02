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

            for (int x = 0; x < 4; x++)
            {
                for (int y = 2; y <= 10; y++)
                {
                    string cardNumber = y.ToString();
                    //string line = y.ToString() + " " + suite[x];
                    deckLiteral.Add(y.ToString() + " " + suite[x]);
                    //Console.WriteLine(deckLiteral[y - 2]);
                }
                deckLiteral.Add("J " + suite[x]);
                deckLiteral.Add("Q " + suite[x]);
                deckLiteral.Add("K " + suite[x]);
                deckLiteral.Add("A " + suite[x]);

            }

            return (deckLiteral);
        }

        public List<int> CreateHierarchy()
        {
            List<int> deckNumerical = new List<int>();
            int z = 0;
            int v = 0;
            for (v = 0; v < 4; v++)
            {
                for (z = 1; z < 14; z++)
                {
                    deckNumerical.Add(z);
                }
            }

            return(deckNumerical);

        }
    }
}