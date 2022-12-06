using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunCard
{
    public class Card
    {
        private CardSuit suit;
        private CardRank rank;
    
        public CardRank Rank
        {
            get { return this.rank; }
            set { this.rank = value; }
        }

        public CardRank GetRank()
        {
            return this.rank;
        }

        public void SetRank( CardRank value )
        {
            this.rank = value;
        }


        public Card(CardSuit suit, CardRank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }



        public int GetValue()
        {
            return (int)this.suit * (int)this.rank;
        }

        public override string ToString()
        {
            return ("Card: " + this.suit + ":" + this.rank + " value: " + this.GetValue());
        }

    }
}
