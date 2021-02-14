using System;
using System.Collections.Generic;

namespace deckofcards
{
    public class CardDeck{
        private List<int> cards = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 
                   9, 10, 11, 12, 13, 14, 15, 
                   16, 17, 18, 19, 20, 21, 22, 
                   23, 24, 25, 26, 27, 28, 29, 
                   30, 31, 32, 33, 34, 35, 36, 
                   37, 38, 39, 40, 41, 42, 43, 
                   44, 45, 46, 47, 48, 49, 50,  
                   51};
        public void Shuffle()
        {
            this.cards.Shuffle();
        }
        public Card Play()
        {
            int card = this.cards[0];
            this.cards.RemoveAt(0);
            return new Card(card);
        }
        public bool CanContinue()
        {
            return this.cards.Count >= 1;
        }
        public CardDeck()
        {
            this.Shuffle();
        }        
    }
public class Card{
    private enum Suit{
        HEARTS, CLUBS, SPADES, DIAMONDS
    }
    private int value;
    private Suit suit;
    public Card(int cardNumber)
{
    this.suit = (Suit)(cardNumber / 13);
    this.value = cardNumber % 13 +1;
}
    public override string ToString()
    {
        string suitName = suit.ToString();
        string cardValue = string.Empty;
        switch (value) {
                    case 1:
                        cardValue = "A";
                        break;
                    case 11:
                        cardValue = "J";
                        break;
                    case 12:
                        cardValue = "Q";
                        break;
                    case 13:
                        cardValue = "K";
                        break;
                    default:
                        cardValue = value.ToString();
                        break;
                }
        return cardValue + " OF " +  suitName;
    }
}
}