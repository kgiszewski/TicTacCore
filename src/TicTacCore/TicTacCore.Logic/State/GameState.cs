using TicTacCore.Logic.Managers.Enums;
using TicTacCore.Logic.Players;

namespace TicTacCore.Logic.State
{
    public class GameState
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player CurrentPlayer { get; set; }
        public GameAction NextAction { get; set; }
    }
}
