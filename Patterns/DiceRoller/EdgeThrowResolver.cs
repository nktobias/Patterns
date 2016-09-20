using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DiceRoller
{
    public class EdgeThrowResolver : ThrowResolver
    {
        public override ThrowResult Resolve(IEnumerable<int> numbers)
        {
            List<int> afterEdgeNumbers = new List<int>();
            IEnumerable<int> collection = numbers as int[] ?? numbers.ToArray();
            afterEdgeNumbers.AddRange(collection);

            int count = afterEdgeNumbers.Count(x => x == 6);
            if (count > 0)
            {
                Console.WriteLine("Edge rolls: ");
                for (int i = 0; i < count; i++)
                {
                    int number = DiceRoller.Instance.RollSix();
                    afterEdgeNumbers.Add(number);
                    Console.Write("{0}, ", number);
                }
            }

            int s = 0;
            int g = 0;
            foreach (int number in afterEdgeNumbers)
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
            int mark = collection.Count()/2;
            ThrowResult result = new ThrowResult(ThrowResultType.Success, s);
            return result;
        }
    }
}
