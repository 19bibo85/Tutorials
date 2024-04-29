using DesignPatterns.Interfaces;
using DesignPatterns.Models;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
    /// </summary>
    public class ConcreteFootballClub : FootballClub, IFootballClub
    {
        public ConcreteFootballClub(string name, DateTime founded, string owner, string country, string league, string stadiumName, int stadiumCapacity) : base(name, founded, owner, country, league, stadiumName, stadiumCapacity)
        {
        }

        public ITeam CreateTeam() => new FootballTeam(_name, _country, _league);

        public IStadium CreateStadium() => new FootballStadium(_stadiumName, _stadiumCapacity);
    }

    public class ConcreteBasketballClub : FootballClub, IFootballClub
    {
        public ConcreteBasketballClub(string name, DateTime founded, string owner, string country, string league, string stadiumName, int stadiumCapacity) : base(name, founded, owner, country, league, stadiumName, stadiumCapacity)
        {
        }

        public ITeam CreateTeam() => new BasketballTeam(_name, _country, _league);

        public IStadium CreateStadium() => new BasketballStadium(_stadiumName, _stadiumCapacity);
    }


    public abstract class FootballClub
    {
        #region Protected Members

        protected readonly string _name;
        protected readonly DateTime _founded;
        protected readonly string _owner;
        protected readonly string _country;
        protected readonly string _league;
        protected readonly string _stadiumName;
        protected readonly int _stadiumCapacity;

        #endregion

        #region Constructor

        public FootballClub(string name, DateTime founded, string owner, string country, string league, string stadiumName, int stadiumCapacity)
        {
            _name = name;
            _founded = founded;
            _owner = owner;
            _country = country;
            _league = league;
            _stadiumName = stadiumName;
            _stadiumCapacity = stadiumCapacity;
        }

        #endregion

        public string DisplayInfo() => $"{_name},{_founded},{_owner}";
    }
}
