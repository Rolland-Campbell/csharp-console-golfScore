using System.Collections.Generic;

namespace golfScore_csharp.Interfaces
{
    public interface IGame
    {
         ICourse Course {get; set;}
         Dictionary<IPlayer, int[]> PlayerScores {get; set;}
    }
}