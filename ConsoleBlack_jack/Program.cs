
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlack_jack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("le jeux balck jack");
            ICard firstCard = new Card("A");
            ICard secondCard = new Card("A");
            ICard thirdCard = new Card("A");
            ICard lastCard = new Card("A");
            IHand hand = new Hand(firstCard, secondCard);
            hand.AddCard(thirdCard);
            hand.AddCard(lastCard);
            Console.WriteLine(hand.Points);
            Console.ReadLine();


        }
    }
}
