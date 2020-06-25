using System;
using Newtonsoft.Json;
using TicTacCore.Logic.State;

namespace TicTacCore.Logic.Managers.Events.Args
{
    public class GameStateEventArgs : EventArgs
    {
        public GameState GameState { get; }

        public GameStateEventArgs(
            GameState gameState    
        )
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            //clone it
            GameState = JsonConvert.DeserializeObject<GameState>(JsonConvert.SerializeObject(gameState, settings), settings);
        }
    }
}
