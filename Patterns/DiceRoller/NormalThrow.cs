using System.Collections.Generic;
using System.Linq;

namespace DiceRoller
{
    public class NormalThrowResolver : ThrowResolver
    {
        public override ThrowResult Resolve(IEnumerable<int> numbers)
        {
            int s = 0;
            int g = 0;
            IEnumerable<int> enumerable = numbers as int[] ?? numbers.ToArray();
            foreach (int number in enumerable)
            {
                if (number > 1)
                {
                    s++;
                }
                else
                {
                    g++;
                }
            }
            int mark = enumerable.Count() / 2;
            ThrowResult result = new ThrowResult(g == enumerable.Count() ? ThrowResultType.SuperGlitch : g > mark ? ThrowResultType.Glitch : ThrowResultType.Success, s);
            return result;
        }
    }
}
