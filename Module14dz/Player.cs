using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14HW
{
    class Player
    {
        public string Name { get; }
        public List<Card> Cards { get; } = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public void DisplayCards()
        {
            Console.WriteLine($"{Name}'s cards: {string.Join(", ", Cards.Select(card => $"{card.Tip} {card.Mast}"))}");
        }
    }
}
