using DesignPatterns.Interfaces;

namespace DesignPatterns.Models
{
    public class BasketballStadium : Stadium, IStadium
    {
        public BasketballStadium(string name, int capacity) : base(name, capacity)
        {
        }

        public string DisplayInfo() => $"{nameof(BasketballStadium)}: {ToString()}";
    }
}
