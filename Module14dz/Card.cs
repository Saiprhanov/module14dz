using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14HW
{
    class Card
    {
        public string Mast { get; set; }
        public string Tip { get; set; }

        public Card(string mast, string tip)
        {
            Mast = mast;
            Tip = tip;
        }
    }
}
