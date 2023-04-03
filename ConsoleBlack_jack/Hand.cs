using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlack_jack
{
    public class Hand : IHand
    {
        private List<ICard> cards = new List<ICard>();

        public Hand(ICard firstCard, ICard secondCard)
        {
            this.cards.Add(firstCard);
            this.cards.Add(secondCard);
        }

        public int Points {

         get {
                int sum = 0;
                int recalcule = 0;
                for (int i = 0; i < cards.Count; i++) { 
                    sum += cards[i].Points;
                    if(cards[i].Points == 11)
                    {
                        recalcule++;
                    }
                    if(recalcule > 0 && sum > 21)
                    {
                        recalcule--;
                        sum -= 10;
                    }
                }

                if (recalcule > 0 && sum > 21)
                {
                    recalcule--;
                    sum -= 10;
                }




                return sum;

                //return sum;




            }
            

}


        public bool IsBusted => Points > 21;

        public bool IsBlackjack => Points == 21 && cards.Count == 2;

        public void AddCard(ICard card)
        {
            this.cards.Add(card);
        }
    }
}
