using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card
    {
        public string StringVal;
        public string Suit;

        public int Val;



        public Card(string suit, string stringVal, int val)
        {
            StringVal = stringVal;
            Suit= suit;
            Val = val;
        }
    }
}