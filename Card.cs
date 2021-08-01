using System;
using System.Collections.Generic;

namespace Project
{
public class Card
    {
        //for security of data
        private string suit;
        private string rank;
        public Card(string suit,string rank)
        {
            this.suit=suit;
            this.rank=rank;
        }

        public String getRank()
        {
            return this.rank;
        }

        public new string ToString()
        {
            return (this.rank+" of "+this.suit);
        }
    }
}
