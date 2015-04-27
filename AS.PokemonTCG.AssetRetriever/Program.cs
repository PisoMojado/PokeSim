using System;

namespace AS.PokemonTCG.WebRetriever
{
    class Program
    {
        static void Main(string[] args)
        {
            //We announce that we are beginning
            ConsoleManager.NotifyUser("This program will download assets from bulbapedia and parse them into a format useable by the application.");
            ConsoleManager.NotifyUser("Press ENTER to continue.");
            int a;
            ConsoleManager.ReadInput(out a);
        }
    }
}
