using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14HW
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> playerNames = new List<string> { "Player1", "Player2" };
            Game game = new Game(playerNames);

            foreach (var player in game.Players)
            {
                player.DisplayCards();
            }

            game.Play();
        }
    }
}
