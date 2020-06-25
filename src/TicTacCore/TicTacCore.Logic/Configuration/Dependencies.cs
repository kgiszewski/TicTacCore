using Microsoft.Extensions.DependencyInjection;
using TicTacCore.Logic.Managers;
using TicTacCore.Logic.State;

namespace TicTacCore.Logic.Configuration
{
    public static class Dependencies
    {
        public static void Register(ServiceCollection services)
        {
            services.AddSingleton<GameState>();
            services.AddSingleton<IGameManager, GameManager>();
        }
    }
}
