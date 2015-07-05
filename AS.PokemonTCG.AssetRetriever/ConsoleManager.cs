using System;

namespace AS.PokemonTCG.WebRetriever
{
    public static class ConsoleManager
    {
        public static void NotifyUser(string message)
        {
            Console.WriteLine(message);
            //Yet another superficial change for GitHub
        }

        public static void ReadInput(out int input)
        {
            input = Convert.ToInt32(Console.ReadLine());
        }

        public static void ReadInput(out string input)
        {
            input = Console.ReadLine();
        }

        public static void ReadInput(out double input)
        {
            input = Convert.ToDouble(Console.ReadLine());
            //This is a superficial comment for github
        }
    }
}
