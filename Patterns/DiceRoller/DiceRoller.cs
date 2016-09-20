using System;

namespace DiceRoller
{
    public class DiceRoller
    {
        private readonly Random _random;
        private static DiceRoller _instance;

        public static DiceRoller Instance => _instance ?? (_instance = new DiceRoller());

        private DiceRoller()
        {
            _random = new Random();
        }

        public int RollSix()
        {
            return _random.Next(1, 7);
        }
    }
}
