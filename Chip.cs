using System;
using System.Collections.Generic;

namespace Project
{
public class Chip
    {
        private int total;
        private int bet;
        public Chip()
        {
            this.total=100;
            this.bet=0;
        }
        public Chip(int total)
        {
            this.total=total;
        }

        public void win_bet()
        {
            this.total=this.total+this.bet;
        }

        public void lose_bet()
        {
            this.total=this.total-this.bet;
        }

        public int getTotal()
        {
            return this.total;
        }
        public int getBet()
        {
            return this.bet;
        }
        public void setBet(int bet)
        {
            this.bet=bet;
        }
    }

}