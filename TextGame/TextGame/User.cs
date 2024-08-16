using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    public class User
    {
        private string _name;
        private int _index;
        private GCWCard _card;

        public GCWCard GetCard()
        {
            return _card;
        }

        public void ReceiveCard(GCWCard card)
        {
            this._card = card;  
        }

        public User(string name, int index)
        {
            _name = name;   
            _index = index;
            _card = null;
        }
    }
}
