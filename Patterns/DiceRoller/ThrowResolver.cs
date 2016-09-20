using System.Collections.Generic;

namespace DiceRoller
{
    public abstract class ThrowResolver
    {
        public abstract ThrowResult Resolve(IEnumerable<int> number);
    }
}
