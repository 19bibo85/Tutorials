namespace DesignPatterns.Models
{
    public abstract class Player
    {
        #region Private Members

        private readonly string _name;
        private readonly string _surname;
        private readonly string _team;

        #endregion

        #region Constrctor

        public Player(string name, string surname, string team) 
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

        public override string ToString() => $"{Name},{Surname},{Team}";
    }
}
