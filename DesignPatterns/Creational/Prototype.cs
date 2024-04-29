using DesignPatterns.Models;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.
    /// </summary>
    public abstract class ClonablePlayer
    {
        #region Private Members

        private readonly string _name;
        private readonly string _surname;
        private readonly string _team;

        #endregion

        #region Constructor

        public ClonablePlayer(string name, string surname, string team)
        {
            _name = name;
            _surname = surname;
            _team = team;
        }

        #endregion

        #region Properties

        public string Name => _name;
        public string Surname => _surname;
        public string Team => _team;

        #endregion

        public abstract ClonablePlayer Clone();
    }

    public class ClonableFootballPlayer : ClonablePlayer
    {
        public ClonableFootballPlayer(string name, string surname, string team) : base(name, surname, team)
        {

        }

        public override ClonablePlayer Clone() => (ClonablePlayer) this.MemberwiseClone();

        public override string ToString() => $"Football: {Name},{Surname},{Team}";
    }

    public class ClonableBasketballPlayer : ClonablePlayer
    {
        public ClonableBasketballPlayer(string name, string surname, string team) : base(name, surname, team)
        {

        }

        public override ClonablePlayer Clone() => (ClonablePlayer)this.MemberwiseClone();

        public override string ToString() => $"Basketball: {Name},{Surname},{Team}";
    }
}
