using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            this.Name = name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck deck)
        {
            Card theCard = deck.Deal();
            Hand.Add(theCard);
            return theCard;
        }

        public Card Discard(int idx)
        {
            Card theCard;
            if(idx < Hand.Count)
            {
                theCard = Hand[idx];
                Hand.RemoveAt(idx);
                return theCard;
            }
            else { return null; }
        }

    }
}