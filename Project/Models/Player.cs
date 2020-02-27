using golfScore_csharp.Interfaces;

namespace golfScore_csharp.Models
{
    public class Player : IPlayer
    {
        public string Name {get; set;}
        
        public Player (string name){
            Name = name;
        }
    }
}