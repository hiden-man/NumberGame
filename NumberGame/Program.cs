using System;

namespace NumberGame
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("********* Number Game *********");
        ContinueProgram:
            var variable1 = random.Next(100) + 1;
            while (true)
            {
                Console.WriteLine("Enter your value, please.");
                var variable = Convert.ToInt32(Console.ReadLine());
                if (variable < variable1)
                    Console.WriteLine($"Your value < secret number");
                if (variable > variable1)
                    Console.WriteLine("Variable > secret number");
                if (variable == variable1)
                {
                    Console.WriteLine("You win");
                    Console.WriteLine("do You want to continue?\n 1 - Y, 0 - N");
                    var exitVar = Convert.ToInt32(Console.ReadLine());
                    if (exitVar == 1)
                        goto ContinueProgram;
                    if (exitVar == 0)
                        break;
                }
            }
        }
    }
}
