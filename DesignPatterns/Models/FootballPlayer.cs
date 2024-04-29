using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public sealed class FootballPlayer : Player, IPlayer
    {
        public FootballPlayer(string name, string surname, string team) : base(name, surname, team) 
        {

        }

        public string DisplayInfo() => $"Football Player: {base.ToString()}";
    }
}
