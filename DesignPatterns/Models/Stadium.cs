namespace DesignPatterns.Models
{
    public abstract class Stadium
    {
        #region Private Members

        private readonly string _name;
        private readonly int _capacity;

        #endregion

        #region Constructor

        public Stadium(string name, int capacity)
        {
            _name = name;
            _capacity = capacity;
        }

        #endregion

        #region Properties

        public override string ToString() => $"{_name},{_capacity}";

        #endregion
    }
}
