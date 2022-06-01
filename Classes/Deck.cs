using System;
using System.Collections.Generic;

namespace CSE210_02.Classes
{
    public class Deck
    {
        public List<string> hashList = new List<string>();
        public Dictionary<string, int> deck = new Dictionary<string, int>();
        public Deck()
        {
            List<string> suite = new List<string>();
            suite.Add("Heart");
            suite.Add("Spade");
            suite.Add("Diamond");
            suite.Add("Club");

            List<string> faceCard = new List<string>();
            faceCard.Add("J");
            faceCard.Add("Q");
            faceCard.Add("K");
            faceCard.Add("J");

            for (int x = 0; x < 4; x++)
            {
                string deckLiteral;
                int yankee;
                int zulu;

                for (yankee = 2; yankee <= 10; yankee++)
                {
                    deckLiteral = (yankee.ToString() + " " + suite[x]);
                    int deckNumerical = yankee;
                    deck.Add(deckLiteral, deckNumerical);
                    hashList.Add(deckLiteral);

                }
                for (zulu = 0; zulu < 4; zulu++)
                {
                    deckLiteral = (faceCard[zulu] + suite[x]);
                    yankee += yankee;
                    int deckNumerical = yankee;
                    deck.Add(deckLiteral, deckNumerical);
                    hashList.Add(deckLiteral);

                }
            }
        }

        public Dictionary<string, int> GetDeck()
        {
            return(deck);
        }

        public List<string> GetHash()
        {
            return(hashList);
        }
    }
}