using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunCard
{
    public class Player
    {

        public const int NUMBER_OF_PLAYER_CARDS = 3;

        private readonly string name;
        private readonly Card[] cards;
        private int cardIndex;

        public Card this[int index]
        {
            get { return this.cards[index]; }
            set { this.cards[index] = value; }
        }

        public Player(String name)
        {
            this.name = name;
            this.cards = new Card[NUMBER_OF_PLAYER_CARDS];
            this.cardIndex = 0;
        }

        public void AddCard(Card card)
        {
            if (this.cardIndex < NUMBER_OF_PLAYER_CARDS)
            {
                this.cards[this.cardIndex++] = card;
            }
        }

        public void DropCards()
        {
            this.cardIndex = 0;
        }

        public int GetCardsValue()
        {
            int ret = 0;
            for (int i = 0; i < this.cardIndex; i++)
            {
                if (this.cards[i] != null)
                {
                    ret += this.cards[i].GetValue();
                }
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(300);
            builder.AppendLine("Player " + this.name);
            for (int i = 0; i < this.cardIndex; i++)
            {
                if (this.cards[i] != null)
                {
                    builder.Append("(" + (i + 1) + ") ");
                    builder.AppendLine(this.cards[i].ToString());
                }
            }
            builder.AppendLine("SumValues: " + this.GetCardsValue());
            return builder.ToString();
        }


    }
}
