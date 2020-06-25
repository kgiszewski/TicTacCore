using Microsoft.Extensions.DependencyInjection;
using TicTacCore.Logic.Managers;
using TicTacCore.Logic.Managers.Enums;
using TicTacCore.UI.Display;

namespace TicTacCore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            Logic.Configuration.Dependencies.Register(services);
            UI.Configuration.Dependencies.Register(services);

            var provider = services.BuildServiceProvider();

            var manager = provider.GetRequiredService<IGameManager>();
            var gridRenderer = provider.GetRequiredService<IRenderGrids>();

            manager.OnGameStarted += (sender, eventArgs) =>
            {
                System.Console.WriteLine($"Starting...");
            };

            manager.OnGameEnded += (sender, eventArgs) =>
            {
                System.Console.WriteLine(eventArgs.GameState.NextAction == GameAction.GameOverCatGame ? $"Game over, cat game!" : $"Game over winner!");
            };

            manager.OnGameStarted += (sender, eventArgs) =>
            {
                gridRenderer.Render(eventArgs.GameState);
            };

            manager.OnCoinFlipped += (sender, eventArgs) =>
            {
                System.Console.WriteLine($"{eventArgs.Player.Name} won the toss!");
            };

            manager.OnPlayerBeginTurn += (sender, eventArgs) =>
            {
                System.Console.WriteLine($"Waiting for {eventArgs.Player.Name} to make their move...");
            };

            manager.OnPlayerEndTurn += (sender, eventArgs) =>
            {
                System.Console.WriteLine($"Waiting for {eventArgs.Player.Name} has made their move.");
            };

            manager.Start();
        }
    }
}
