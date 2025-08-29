using System;

namespace Hodilki_brodilki
{
    public class Game
    {
        public static void Main()
        {
            Random rndm = new Random();
            
            bool Game_Working = true;

            while (Game_Working)
            {
                String? Line = Console.ReadLine();
                Line = Line.ToLower();
                Line = Line.Trim();

                if (Line.Length == 1)
                {
                    Map.Message(Line);
                    Map.Draw_Level();
                }
                else
                {
                    Commands.Analysis(Line);
                }
            }
        }
    }
}