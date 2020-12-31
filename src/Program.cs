using System;
using Steamworks;

namespace Idler
{
    class Program
    {
        static void Main()
        {
            string appID = "";

            while (string.IsNullOrEmpty(appID))
            {
                Console.WriteLine("Enter the game's App ID: ");
                appID = Console.ReadLine();
                Console.Clear();
            }

            Environment.SetEnvironmentVariable("SteamAppId", appID);
            bool initialized = SteamAPI.Init();
            Console.Clear();

            if (!initialized) {
                Console.WriteLine("Failed to initialize Steam API. Is the Steam client running?");
            }

            while(Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
