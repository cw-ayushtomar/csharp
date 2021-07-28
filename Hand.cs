using System;
using System.Collections.Generic;

namespace Project
{
public class Hand
    {
        private List<Card> cards = new List<Card>();
        private long value;
        private int aces;
        public Hand()
        {
            this.cards.Clear();
            this.value=0;
            this.aces=0;
        }

        public void add_card(Card card,Dictionary<string, int> values)
        {
            this.cards.Add(card);
            this.value=this.value+values[card.getRank()];
        
            if (card.getRank().Equals("ace")==true)
                this.aces=this.aces+1;
        }

        public void adjust_ace()
        {   

            if (this.value>21 && this.aces>0)
            {
                this.value=this.value-10;
                this.aces=this.aces-1;

            }
        }

        public List<Card> getCards()
        {
            return cards;
        }
        public long getValue()
        {
            return value;
        }
    }
}
