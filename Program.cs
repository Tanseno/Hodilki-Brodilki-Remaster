using System;

namespace Hodilki_brodilki
{
    public class Game
    {
        public static int[] Player_pos = new int[] { 9, 14 };
        public static int Balance = 0;
        public static void Main()
        {
            Random rndm = new Random();


            string Player = "@";
            bool Game_Working = true;

            string[,] Map ={                                                                                                 // карта (map)                          
            {".", ".", ".", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■"},
            {".", ".", ".", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "■", "■"},
            {".", ".", ".", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■"},
            {".", ".", ".", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■", "■"},
            };
            Map[Player_pos[1], Player_pos[0]] = Player;
            while (Game_Working)
            {
                String? word = Console.ReadLine();
                word = word.ToLower();
                word = word.Trim();
                if (word.Length == 1)
                {
                    Map[Player_pos[1], Player_pos[0]] = ".";
                    switch (word)
                    {
                        case "w":
                            if (Check_Ahead(Map) == ".")
                            {
                                Player_pos[1] -= 1;
                            }
                            else if (Check_Back(Map) == "$")
                            {
                                Player_pos[1] -= 1;
                                Balance += 1;
                            }
                            break;



                        case "s":
                            if (Check_Back(Map) == ".")
                            {
                                Player_pos[1] += 1;
                            }
                            else if (Check_Back(Map) == "$")
                            {
                                Player_pos[1] += 1;
                                Balance += 1;
                            }
                            break;


                        case "d":
                            if (Check_Right(Map) == ".")
                            {
                                Player_pos[0] += 1;
                            }
                            else if (Check_Back(Map) == "$")
                            {
                                Player_pos[0] += 1;
                                Balance += 1;
                            }
                            break;


                        case "a":
                            if (Check_Left(Map) == ".")
                            {
                                Player_pos[0] -= 1;
                            }
                            else if (Check_Back(Map) == "$")
                            {
                                Player_pos[0] -= 1;
                                Balance += 1;
                            }
                            break;


                        case "e":
                            break;
                    }
                    Map[Player_pos[1], Player_pos[0]] = Player;
                    Draw_Map(Map);
                }
            }
        }


        public static string Check_Left(string[,] Map)
        {
            string Square = Map[Player_pos[1], Player_pos[0] - 1];
            return Square;
        }
        public static string Check_Right(string[,] Map)
        {
            string Square = Map[Player_pos[1], Player_pos[0] + 1];
            return Square;
        }
        public static string Check_Ahead(string[,] Map)
        {
            string Square = Map[Player_pos[1] - 1, Player_pos[0]];
            return Square;
        }
        public static string Check_Back(string[,] Map)
        {
            string Square = Map[Player_pos[1] + 1, Player_pos[0]];
            return Square;
        }
        

        public static void Draw_Map(string[,] map)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[2, 5], map[2, 6], map[2, 7], map[2, 8], map[2, 9], map[2, 10], map[2, 11], map[2, 12], map[2, 13], map[2, 14], map[2, 15], map[2, 16], map[2, 17], map[2, 18], map[2, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[3, 5], map[3, 6], map[3, 7], map[3, 8], map[3, 9], map[3, 10], map[3, 11], map[3, 12], map[3, 13], map[3, 14], map[3, 15], map[3, 16], map[3, 17], map[3, 18], map[3, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[4, 5], map[4, 6], map[4, 7], map[4, 8], map[4, 9], map[4, 10], map[4, 11], map[4, 12], map[4, 13], map[4, 14], map[4, 15], map[4, 16], map[4, 17], map[4, 18], map[4, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[5, 5], map[5, 6], map[5, 7], map[5, 8], map[5, 9], map[5, 10], map[5, 11], map[5, 12], map[5, 13], map[5, 14], map[5, 15], map[5, 16], map[5, 17], map[5, 18], map[5, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[6, 5], map[6, 6], map[6, 7], map[6, 8], map[6, 9], map[6, 10], map[6, 11], map[6, 12], map[6, 13], map[6, 14], map[6, 15], map[6, 16], map[6, 17], map[6, 18], map[6, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[7, 5], map[7, 6], map[7, 7], map[7, 8], map[7, 9], map[7, 10], map[7, 11], map[7, 12], map[7, 13], map[7, 14], map[7, 15], map[7, 16], map[7, 17], map[7, 18], map[7, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[8, 5], map[8, 6], map[8, 7], map[8, 8], map[8, 9], map[8, 10], map[8, 11], map[8, 12], map[8, 13], map[8, 14], map[8, 15], map[8, 16], map[8, 17], map[8, 18], map[8, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[9, 5], map[9, 6], map[9, 7], map[9, 8], map[9, 9], map[9, 10], map[9, 11], map[9, 12], map[9, 13], map[9, 14], map[9, 15], map[9, 16], map[9, 17], map[9, 18], map[9, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[10, 5], map[10, 6], map[10, 7], map[10, 8], map[10, 9], map[10, 10], map[10, 11], map[10, 12], map[10, 13], map[10, 14], map[10, 15], map[10, 16], map[10, 17], map[10, 18], map[10, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[11, 5], map[11, 6], map[11, 7], map[11, 8], map[11, 9], map[11, 10], map[11, 11], map[11, 12], map[11, 13], map[11, 14], map[11, 15], map[11, 16], map[11, 17], map[11, 18], map[11, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[12, 5], map[12, 6], map[12, 7], map[12, 8], map[12, 9], map[12, 10], map[12, 11], map[12, 12], map[12, 13], map[12, 14], map[12, 15], map[12, 16], map[12, 17], map[12, 18], map[12, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[13, 5], map[13, 6], map[13, 7], map[13, 8], map[13, 9], map[13, 10], map[13, 11], map[13, 12], map[13, 13], map[13, 14], map[13, 15], map[13, 16], map[13, 17], map[13, 18], map[13, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[14, 5], map[14, 6], map[14, 7], map[14, 8], map[14, 9], map[14, 10], map[14, 11], map[14, 12], map[14, 13], map[14, 14], map[14, 15], map[14, 16], map[14, 17], map[14, 18], map[14, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[15, 5], map[15, 6], map[15, 7], map[15, 8], map[15, 9], map[15, 10], map[15, 11], map[15, 12], map[15, 13], map[15, 14], map[15, 15], map[15, 16], map[15, 17], map[15, 18], map[15, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", map[16, 5], map[16, 6], map[16, 7], map[16, 8], map[16, 9], map[16, 10], map[16, 11], map[16, 12], map[16, 13], map[16, 14], map[16, 15], map[16, 16], map[16, 17], map[16, 18], map[16, 19]);

        }
    }
}