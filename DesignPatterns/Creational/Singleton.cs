using DesignPatterns.Interfaces;

namespace DesignPatterns.Creational
{
    /// <summary>
    /// Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
    /// </summary>
    public class Singleton
    {
        private static IPlayer? _player;

        private Singleton(IPlayer player)
        {
            if (_player == null)
                _player = player;
        }
        public static void Create(IPlayer player)
        {
            _ = new Singleton(player);
        }

        public static IPlayer? Player => _player;
    }    
}
