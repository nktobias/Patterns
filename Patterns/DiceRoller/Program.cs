using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DiceRoller.Instance.RollSix());
            Console.WriteLine(DiceRoller.Instance.RollSix());
            Console.WriteLine(DiceRoller.Instance.RollSix());
            Console.WriteLine(DiceRoller.Instance.RollSix());
            Console.WriteLine(DiceRoller.Instance.RollSix());

            Console.ReadLine();
        }
    }
}
