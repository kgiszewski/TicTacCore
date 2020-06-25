using TicTacCore.Logic.Managers.Events.Args;

namespace TicTacCore.Logic.Managers.Events
{
    public delegate void GameStarting(object sender, GameStateEventArgs e);
    public delegate void GameStarted(object sender, GameStateEventArgs e);

    public delegate void CoinFlipped(object sender, PlayerEventArgs e);

    public delegate void GameEnded(object sender, GameStateEventArgs e);

    public delegate void PlayerBeginTurn(object sender, PlayerEventArgs e);
    public delegate void PlayerEndTurn(object sender, PlayerEventArgs e);

    public delegate void GetPlayerMove(object sender, PlayerEventArgs e);

}
