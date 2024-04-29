using DesignPatterns.Creational;
using DesignPatterns.Models;

namespace DesignPatterns.Fixtures
{
    public class PlayerFixture
    {
        public static FootballPlayer FootballPlayer1 => new("Paolo", "Maldini", "AC Milan");
        public static FootballPlayer FootballPlayer2 => new ("Alessandro", "Costacurta", "AC Milan");

        public static ConcreteFootballPlayer ConcreteFootballPlayer = new ("Paolo", "Maldini", "AC Milan");

        public static ConcreteBasketPlayer ConcreteBasketPlayer = new("Michael", "Jordan", "Chicago Bulls");

        public static ClonableFootballPlayer ClonableFootballPlayer = new("Paolo", "Maldini", "AC Milan");

        public static ClonableBasketballPlayer ClonableBasketballPlayer = new("Michael", "Jordan", "Chicago Bulls");

    }
}
