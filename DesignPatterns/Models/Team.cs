namespace DesignPatterns.Models
{
    public abstract class Team
    {
        #region Private Members

        private readonly string _name;
        private readonly string _country;
        private readonly string _league;

        #endregion

        #region Constructor

        public Team(string name, string county, string league) 
        {
            _name = name;
            _country = county;
            _league = league;
        }

        #endregion

        #region Properties

        public override string ToString() => $"{_name},{_country},{_league}";

        #endregion
    }
}
