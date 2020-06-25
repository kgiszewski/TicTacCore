using TicTacCore.Logic.Managers.Enums;
using TicTacCore.Logic.Managers.Events;

namespace TicTacCore.Logic.Managers
{
    public interface IGameManager
    {
        void Start();
        void HandleAction(GameAction action);

        event GameStarting OnGameStarting;
        event GameStarted OnGameStarted;
        event GameEnded OnGameEnded;
        event CoinFlipped OnCoinFlipped;
        event PlayerBeginTurn OnPlayerBeginTurn;
        event PlayerEndTurn OnPlayerEndTurn;
        event GetPlayerMove OnGetPlayerMove;
    }
}
