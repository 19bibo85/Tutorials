using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public class FootballStadium : Stadium, IStadium
    {
        public FootballStadium(string name, int capacity) : base(name, capacity)
        {
        }

        public string DisplayInfo() => $"{nameof(FootballStadium)}: {ToString()}";
    }
}
