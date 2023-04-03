using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlack_jack
{
    public class Card : ICard
    {


        private string _value; 
        public Card(string value)
        {
            this._value = value;
        }

        public int Points
        {
            get
            { 
                
                if(this._value == "J" || this._value == "Q" || this._value == "K")
                    return 10;
                else if(this._value == "A")
                    return 11;
                else 
                    return int.Parse(this._value);
            }
           


        }
    }
}
