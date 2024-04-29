using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public sealed class FootballTeam : Team, ITeam
    {
        public FootballTeam(string name, string county, string league) : base(name, county, league)
        {

        }

        public string DisplayInfo() => $"{nameof(FootballTeam)}: {ToString()}";
    }
}
