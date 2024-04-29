using DesignPatterns.Creational;

namespace DesignPatterns.Fixtures
{
    public class ClubFixtures
    {
        public static ConcreteFootballClub FootballClub => new("AC Milan", new DateTime(1899, 12, 13), "RedBird Capital Partners", "Italy", "Serie A", "Stadio Meazza in San Siro", 80_018);

        public static ConcreteBasketballClub BasketballClub => new("Chicago Bulls", new DateTime(1966, 01, 01), "Jerry Reinsdorf", "United States", "NBA - Eastern", "United Center", 23_500);
    }
}
