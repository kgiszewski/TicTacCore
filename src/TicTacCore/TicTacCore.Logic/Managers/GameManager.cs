using TicTacCore.Logic.Managers.Enums;
using TicTacCore.Logic.Managers.Events;
using TicTacCore.Logic.Managers.Events.Args;
using TicTacCore.Logic.Players;
using TicTacCore.Logic.State;

namespace TicTacCore.Logic.Managers
{
    public class GameManager : IGameManager
    {
        private readonly GameState _gameState;
        public event GameStarting OnGameStarting;
        public event GameStarted OnGameStarted;
        public event GameEnded OnGameEnded;
        public event CoinFlipped OnCoinFlipped;
        public event PlayerBeginTurn OnPlayerBeginTurn;
        public event PlayerEndTurn OnPlayerEndTurn;
        public event GetPlayerMove OnGetPlayerMove;

        public GameManager(
            GameState gameState    
        )
        {
            _gameState = gameState;
        }

        public void Start()
        {
            OnGameStarting?.Invoke(this, new GameStateEventArgs(_gameState));

            _gameState.PlayerOne = new Player
            {
                Name = "Player 1",
                Marker = 'X',
                IsHuman = true
            };

            _gameState.PlayerTwo = new Player
            {
                Name = "Player 2",
                Marker = 'O',
                IsHuman = true
            };

            _gameState.CurrentPlayer = _gameState.PlayerOne;

            HandleAction(GameAction.CoinFlip);

            //get human player count
            //setup any AI

            OnGameStarted?.Invoke(this, new GameStateEventArgs(_gameState));
        }

        public void HandleAction(GameAction action)
        {
            switch (action)
            {
                case GameAction.CoinFlip:
                    OnCoinFlipped?.Invoke(this, new PlayerEventArgs(_gameState.CurrentPlayer));
                    break;

                case GameAction.PlayerMakeMove:
                    OnPlayerBeginTurn?.Invoke(this, new PlayerEventArgs(_gameState.CurrentPlayer));

                    OnGetPlayerMove?.Invoke(this, new PlayerEventArgs(_gameState.CurrentPlayer));

                    //evaluate the move
                    _evaluateMove();

                    OnPlayerEndTurn?.Invoke(this, new PlayerEventArgs(_gameState.CurrentPlayer));
                    break;

                case GameAction.GameOverCatGame:
                    OnGameEnded?.Invoke(this, new GameStateEventArgs(_gameState));
                    break;

                case GameAction.GameOverPlayerWins:
                    OnGameEnded?.Invoke(this, new GameStateEventArgs(_gameState));
                    break;
            }
        }

        private void _evaluateMove()
        {

        }
    }
}
