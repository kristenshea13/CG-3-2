using System;

namespace CG_3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Game of Chance");
            Console.Write("Choose a number between 1 and 10: ");

            string userValue = Console.ReadLine();
            string message = (userValue == "8") ? "You Win!" : "You Lose.";

            Console.WriteLine(message);

            Console.ReadLine();






        }
    }
}
