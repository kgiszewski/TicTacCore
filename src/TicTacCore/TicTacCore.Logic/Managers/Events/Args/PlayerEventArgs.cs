using System;
using Newtonsoft.Json;
using TicTacCore.Logic.Players;

namespace TicTacCore.Logic.Managers.Events.Args
{
    public class PlayerEventArgs : EventArgs
    {
        public Player Player { get; }

        public PlayerEventArgs(
            Player player    
        )
        {
            //clone it
            Player = JsonConvert.DeserializeObject<Player>(JsonConvert.SerializeObject(player));
        }
    }
}
