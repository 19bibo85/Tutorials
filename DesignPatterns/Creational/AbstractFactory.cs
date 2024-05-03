using DesignPatterns.Interfaces;
using DesignPatterns.Models;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
    /// </summary>
    public class ConcreteFootballClub : AbstractClub, IClub
    {
        public ConcreteFootballClub(Club club) : base(club)
        {
        }

        public ITeam CreateTeam() => new FootballTeam(_club.Name, _club.Country, _club.League);

        public IStadium CreateStadium() => new FootballStadium(_club.StadiumName, _club.StadiumCapacity);
    }

    public class ConcreteBasketballClub : AbstractClub, IClub
    {
        public ConcreteBasketballClub(Club club) : base(club)
        {
        }

        public ITeam CreateTeam() => new BasketballTeam(_club.Name, _club.Country, _club.League);

        public IStadium CreateStadium() => new BasketballStadium(_club.StadiumName, _club.StadiumCapacity);
    }


    public abstract class AbstractClub
    {
        #region Protected Members

        protected readonly Club _club;

        #endregion

        #region Constructor

        public AbstractClub(Club club)
        {
            _club = club;
        }

        #endregion

        public string DisplayInfo() => $"{_club.Name},{_club.Founded},{_club.Owner}";
    }
}
