using DesignPatterns.Creational;
using DesignPatterns.Models;

namespace DesignPatterns.Fixtures
{
    public class ClubFixtures
    {
        public static ConcreteFootballClub FootballClub => new(new Club() { Name = "AC Milan", Founded = new DateTime(1899, 12, 13), Owner = "RedBird Capital Partners", Country = "Italy", League = "Serie A", StadiumName = "Stadio Meazza in San Siro", StadiumCapacity = 80_018 });

        public static ConcreteBasketballClub BasketballClub => new(new Club() { Name = "Chicago Bulls", Founded = new DateTime(1966, 01, 01), Owner = "Jerry Reinsdorf", Country = "United States", League = "NBA - Eastern", StadiumName = "United Center", StadiumCapacity = 23_500 });
    }
}
