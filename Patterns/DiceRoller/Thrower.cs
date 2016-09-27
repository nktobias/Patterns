using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Thrower
    {
        private readonly ThrowResolver _throwResolver;

        public event EventHandler SixWasRolled;

        public Thrower(ThrowResolver throwResolver)
        {
            _throwResolver = throwResolver;
        }

        public ThrowResult Throw(int diceCount)
        {
            List<int> dices = new List<int>();
            for (int i = 0; i < diceCount; i++)
            {
                int number = DiceRoller.Instance.RollSix();
                dices.Add(number);
                if (number == 6)
                {
                    OnSixWasRolled();
                }
                Console.Write("{0}, ", number);
            }
            return _throwResolver.Resolve(dices.ToArray());
        }

        protected virtual void OnSixWasRolled()
        {
            SixWasRolled?.Invoke(this, EventArgs.Empty);
        }
    }
}
