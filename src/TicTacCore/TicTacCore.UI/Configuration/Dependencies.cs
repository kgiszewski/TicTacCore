using Microsoft.Extensions.DependencyInjection;
using TicTacCore.UI.Display;

namespace TicTacCore.UI.Configuration
{
    public static class Dependencies
    {
        public static void Register(ServiceCollection services)
        {
            services.AddSingleton<IRenderGrids, ConsoleGridRenderer>();
        }
    }
}
