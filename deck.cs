using System;
using System.Collections.Generic;

namespace DeckOfCards
{
class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            Cards = new List<Card>();
            
            // string[] suits = {"Hearts", "Diamonds", "Clubs", "Spades"};
            // string[] stringVal = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            // for(int i = 0; i < suits.Length; i++)
            // {
            //     for(int j = 0; j < stringVal.Length; j++)
            //     {
            //         Cards.Add(new Card(suits[i], stringVal[j], j+1));
            //         System.Console.WriteLine($"This is the {stringVal[j]} of {suits[i]}");
            //     }    
            // }
            this.Reset();
        }
        public Card Deal()
        {
            Card card = Cards[0];
            System.Console.WriteLine($"You were dealt {card.StringVal} of {card.Suit}");
            Cards.RemoveAt(0);
            return card; 
        }
        public void Reset()
        {
            Cards.Clear();
            string[] suits = {"Hearts", "Diamonds", "Clubs", "Spades"};
            string[] stringVal = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
            for(int i = 0; i < suits.Length; i++)
            {
                for(int j = 0; j < stringVal.Length; j++)
                {
                    Cards.Add(new Card(suits[i], stringVal[j], j+1));
                    // System.Console.WriteLine($"This is the {stringVal[j]} of {suits[i]}");
                }    
            }
        }

        public void Shuffle()
        {
            List<Card> cards = this.Cards;
            List<Card> shuffled = new List<Card>();
            Random rng = new Random();
            while(cards.Count > 0)
            {
                int index = rng.Next(0, cards.Count);
                shuffled.Add(cards[index]);
                cards.RemoveAt(index);
            }
            this.Cards = shuffled;
        }
    }
}