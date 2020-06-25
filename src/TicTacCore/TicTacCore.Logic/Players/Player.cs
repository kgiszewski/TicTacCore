using TicTacCore.Logic.AI;

namespace TicTacCore.Logic.Players
{
    public class Player
    {
        public string Name { get; set; }
        public char Marker { get; set; }
        public bool IsHuman { get; set; }
        public IAiStrategy AiStrategy { get; set; }

        public void MakeMove()
        {

        }
    }
}
