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
                String? word = Console.ReadLine();
                word = word.ToLower();
                word = word.Trim();

                if (word.Length == 1)
                {
                    Map.Message(word);
                    Map.Draw_Level();
                }
            }
        }
    }
}