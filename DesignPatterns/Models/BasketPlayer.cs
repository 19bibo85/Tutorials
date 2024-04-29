using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public sealed class BasketPlayer : Player, IPlayer
    {
        public BasketPlayer(string name, string surname, string team) : base(name, surname, team)
        {

        }

        public string DisplayInfo() => $"Basket Player: {base.ToString()}";
    }
}
