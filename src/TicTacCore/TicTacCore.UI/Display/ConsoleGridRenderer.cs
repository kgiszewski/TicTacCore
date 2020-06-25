using System;
using TicTacCore.Logic.State;

namespace TicTacCore.UI.Display
{
    public class ConsoleGridRenderer : IRenderGrids
    {
        public void Render(GameState gameState)
        {
            Console.WriteLine("Rendering...");
        }
    }
}
