using System;

namespace Hodilki_brodilki
{
    public class Game
    {
        public static void Main()
        {
            Random rndm = new Random();
            
            bool Game_Working = true;

            Map.Draw_Level();

            while (Game_Working)
            {
                String? Line = Console.ReadLine();
                Line = Line.ToLower();
                Line = Line.Trim();
                Commands.Analysis(Line);
            }
        }
    }
}