using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlack_jack
{
    public interface IHand
    {
        int Points { get; }

        bool IsBusted { get; }

        bool IsBlackjack { get; }

        void AddCard(ICard card);
    }
}
