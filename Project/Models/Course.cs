using golfScore_csharp.Interfaces;

namespace golfScore_csharp.Models
{
    public class Course : ICourse
    {
        public string Name {get; set;}
        public int Holes {get; set;}
        public int[] Par {get; set;}

        public Course(string name, int holes, int[] par){
            Name = name;
            Holes = holes;
            Par = par;
        }
    }
}