namespace golfScore_csharp.Interfaces
{
    public interface ICourse
    {
        string Name {get; set;}
        int Holes {get; set;} 
        int[] Par {get; set;}
    }
}