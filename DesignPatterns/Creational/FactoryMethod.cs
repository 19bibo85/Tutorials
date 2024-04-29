using DesignPatterns.Interfaces;
using DesignPatterns.Models;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
    /// </summary>
    public class ConcreteFootballPlayer : AbstractPlayer
    {
        public ConcreteFootballPlayer(string name, string surname, string team) : base(name, surname, team)
        {
        }

        public override IPlayer Create() => new FootballPlayer(_name, _surname, _team);
    }

    public class ConcreteBasketPlayer : AbstractPlayer
    {
        public ConcreteBasketPlayer(string name, string surname, string team) : base(name, surname, team)
        {
        }

        public override IPlayer Create() => new BasketPlayer(_name, _surname, _team);
    }

    public abstract class AbstractPlayer 
    {
        protected string _name;
        protected string _surname;
        protected string _team;

        public AbstractPlayer(string name, string surname, string team) 
        {
            _name = name;
            _surname = surname;
            _team = team;
        }

        public abstract IPlayer Create();
    }
}
