using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public sealed class BasketballTeam : Team, ITeam
    {
        public BasketballTeam(string name, string country, string league) : base(name, country, league)
        {

        }

        public string DisplayInfo() => $"{nameof(BasketballTeam)}: {ToString()}";
    }
}
