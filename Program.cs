﻿using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Here is your deck");
            Deck deck = new Deck();
            deck.Shuffle();
            deck.Deal();


        }
    }
    
}
