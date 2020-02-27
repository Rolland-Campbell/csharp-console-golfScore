using System.Collections.Generic;
using golfScore_csharp.Interfaces;

namespace golfScore_csharp.Models
{
    public class Game : IGame
    {
        public ICourse Course {get; set;}
        public Dictionary<IPlayer, int[]>PlayerScores {get; set;}

        public Game(ICourse course, string[] playernames){
            Course = course;
            PlayerScores = new Dictionary<IPlayer, int[]>();
            for(int i=0; i<playernames.Length; i++){
                string name =  playernames[i];
                PlayerScores.Add(new Player(name), new int[Course.Holes]);
            }
        }
    }
}