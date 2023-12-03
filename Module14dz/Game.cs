using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14HW
{
    class Game
    {
            private List<Player> players = new List<Player>();
            private List<Card> deck = new List<Card>();

            public Game(List<string> playerNames)
            {
                players = playerNames.Select(name => new Player(name)).ToList();
                InitializeDeck();
                ShuffleDeck();
                DealCards();
            }

            private void InitializeDeck()
            {
                string[] masts = { "Hearts", "Diamonds", "Clubs", "Spades" };
                string[] tips = { "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

                foreach (var mast in masts)
                {
                    foreach (var tip in tips)
                    {
                        deck.Add(new Card(mast, tip));
                    }
                }
            }

            private void ShuffleDeck()
            {
                Random random = new Random();
                deck = deck.OrderBy(x => random.Next()).ToList();
            }

            private void DealCards()
            {
                int numberOfPlayers = players.Count;
                int cardsPerPlayer = deck.Count / numberOfPlayers;

                for (int i = 0; i < numberOfPlayers; i++)
                {
                    players[i].Cards.AddRange(deck.GetRange(i * cardsPerPlayer, cardsPerPlayer));
                }
            }

            public void Play()
            {
            }
        }
    }

