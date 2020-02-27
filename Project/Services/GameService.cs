using System.Collections.Generic;
using golfScore_csharp.Interfaces;

namespace golfScore_csharp.Services
{
    public class GameService
    {
        private IGame _game { get; set; }

        public List<ICourse> Courses { get; set; }
        public void AddHoleScores(int[] scores)
        {

        }
        public void NewGame(int course, string[] names)
        {

        } 
    }
}
