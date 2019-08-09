using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    class Game
    {
        public Board board;
        public bool endGame;
        List<Player> players = new List<Player>();
        public Player activePlayer;

        public Board BoardGame { get => board; }
        public bool EndGame { get => endGame; }
        public List<Player> Players { get => players; }
        public Player Player { set => activePlayer = value; }

        public void Play() { }
    }
}
