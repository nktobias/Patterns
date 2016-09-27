using System;

namespace DiceRoller
{
    public class Program
    {
        public static void Main()
        {
            Char c = 'a';
            while (c != 'x')
            {
                c = Console.ReadKey().KeyChar;

                Console.WriteLine("Normal Throw");
                Thrower normalThrower = new Thrower(new NormalThrowResolver());
                normalThrower.SixWasRolled += (sender, args) => Console.Beep(1500, 2000);
                ThrowResult normalResult = normalThrower.Throw(10);
                Console.WriteLine("Result: {0}", normalResult.Type);
                
                Console.WriteLine("Edge throw");
                Thrower thrower = new Thrower(new EdgeThrowResolver());
                thrower.SixWasRolled += (sender, args) => Console.Beep(1500, 2000);
                ThrowResult result = thrower.Throw(10);
                Console.WriteLine("Result: {0}", result.Type);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine();
            }

            Console.WriteLine("Good bye!");
            Console.ReadLine();
        }
    }
}
