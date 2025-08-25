using Hodilki_brodilki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodilki_brodilki
{
    public class Map
    {
        private static int[] Pos = new int[] { 9, 14 };

        private static string[,] Level = {                                                                                                 // карта (Level)                          
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

        public static void Pos_On_Map()
        {
            Pos = Player.Get_Pos();
        }

        public static void Message(string Word)
        {
            Level[Player.Get_Pos_X(), Player.Get_Pos_Y()] = ".";
            switch (Word)
            {
                case "w":
                    if (Check_Ahead(Level) == ".")
                    {
                        Player.Go_Ahead();
                    }
                    else if (Check_Back(Level) == "$")
                    {
                        Player.Go_Ahead();
                        Player.New_Coin();
                    }
                    break;



                case "s":
                    if (Check_Back(Level) == ".")
                    {
                        Player.Go_Back();
                    }
                    else if (Check_Back(Level) == "$")
                    {
                        Player.Go_Back();
                        Player.New_Coin();
                    }
                    break;


                case "d":
                    if (Check_Right(Level) == ".")
                    {
                        Player.Go_Right();
                    }
                    else if (Check_Back(Level) == "$")
                    {
                        Player.Go_Right();
                        Player.New_Coin();
                    }
                    break;


                case "a":
                    if (Check_Left(Level) == ".")
                    {
                        Player.Go_Left();
                    }
                    else if (Check_Back(Level) == "$")
                    {
                        Player.Go_Left();
                        Player.New_Coin();
                    }
                    break;


                case "e":
                    break;
            }
            Level[Player.Get_Pos_X(), Player.Get_Pos_Y()] = Player.Get_Skin();
        }

        public static string Check_Left(string[,] Level)
        {
            string Square = Level[Player.Get_Pos_X(), Player.Get_Pos_Y() - 1];
            return Square;
        }
        public static string Check_Right(string[,] Level)
        {
            string Square = Level[Player.Get_Pos_X(), Player.Get_Pos_Y() + 1];
            return Square;
        }
        public static string Check_Ahead(string[,] Level)
        {
            string Square = Level[Player.Get_Pos_X() - 1, Player.Get_Pos_Y()];
            return Square;
        }
        public static string Check_Back(string[,] Level)
        {
            string Square = Level[Player.Get_Pos_X() + 1, Player.Get_Pos_Y()];
            return Square;
        }


        public static void Draw_Level()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[2, 5], Level[2, 6], Level[2, 7], Level[2, 8], Level[2, 9], Level[2, 10], Level[2, 11], Level[2, 12], Level[2, 13], Level[2, 14], Level[2, 15], Level[2, 16], Level[2, 17], Level[2, 18], Level[2, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[3, 5], Level[3, 6], Level[3, 7], Level[3, 8], Level[3, 9], Level[3, 10], Level[3, 11], Level[3, 12], Level[3, 13], Level[3, 14], Level[3, 15], Level[3, 16], Level[3, 17], Level[3, 18], Level[3, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[4, 5], Level[4, 6], Level[4, 7], Level[4, 8], Level[4, 9], Level[4, 10], Level[4, 11], Level[4, 12], Level[4, 13], Level[4, 14], Level[4, 15], Level[4, 16], Level[4, 17], Level[4, 18], Level[4, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[5, 5], Level[5, 6], Level[5, 7], Level[5, 8], Level[5, 9], Level[5, 10], Level[5, 11], Level[5, 12], Level[5, 13], Level[5, 14], Level[5, 15], Level[5, 16], Level[5, 17], Level[5, 18], Level[5, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[6, 5], Level[6, 6], Level[6, 7], Level[6, 8], Level[6, 9], Level[6, 10], Level[6, 11], Level[6, 12], Level[6, 13], Level[6, 14], Level[6, 15], Level[6, 16], Level[6, 17], Level[6, 18], Level[6, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[7, 5], Level[7, 6], Level[7, 7], Level[7, 8], Level[7, 9], Level[7, 10], Level[7, 11], Level[7, 12], Level[7, 13], Level[7, 14], Level[7, 15], Level[7, 16], Level[7, 17], Level[7, 18], Level[7, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[8, 5], Level[8, 6], Level[8, 7], Level[8, 8], Level[8, 9], Level[8, 10], Level[8, 11], Level[8, 12], Level[8, 13], Level[8, 14], Level[8, 15], Level[8, 16], Level[8, 17], Level[8, 18], Level[8, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[9, 5], Level[9, 6], Level[9, 7], Level[9, 8], Level[9, 9], Level[9, 10], Level[9, 11], Level[9, 12], Level[9, 13], Level[9, 14], Level[9, 15], Level[9, 16], Level[9, 17], Level[9, 18], Level[9, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[10, 5], Level[10, 6], Level[10, 7], Level[10, 8], Level[10, 9], Level[10, 10], Level[10, 11], Level[10, 12], Level[10, 13], Level[10, 14], Level[10, 15], Level[10, 16], Level[10, 17], Level[10, 18], Level[10, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[11, 5], Level[11, 6], Level[11, 7], Level[11, 8], Level[11, 9], Level[11, 10], Level[11, 11], Level[11, 12], Level[11, 13], Level[11, 14], Level[11, 15], Level[11, 16], Level[11, 17], Level[11, 18], Level[11, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[12, 5], Level[12, 6], Level[12, 7], Level[12, 8], Level[12, 9], Level[12, 10], Level[12, 11], Level[12, 12], Level[12, 13], Level[12, 14], Level[12, 15], Level[12, 16], Level[12, 17], Level[12, 18], Level[12, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[13, 5], Level[13, 6], Level[13, 7], Level[13, 8], Level[13, 9], Level[13, 10], Level[13, 11], Level[13, 12], Level[13, 13], Level[13, 14], Level[13, 15], Level[13, 16], Level[13, 17], Level[13, 18], Level[13, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[14, 5], Level[14, 6], Level[14, 7], Level[14, 8], Level[14, 9], Level[14, 10], Level[14, 11], Level[14, 12], Level[14, 13], Level[14, 14], Level[14, 15], Level[14, 16], Level[14, 17], Level[14, 18], Level[14, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[15, 5], Level[15, 6], Level[15, 7], Level[15, 8], Level[15, 9], Level[15, 10], Level[15, 11], Level[15, 12], Level[15, 13], Level[15, 14], Level[15, 15], Level[15, 16], Level[15, 17], Level[15, 18], Level[15, 19]);
            System.Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14}", Level[16, 5], Level[16, 6], Level[16, 7], Level[16, 8], Level[16, 9], Level[16, 10], Level[16, 11], Level[16, 12], Level[16, 13], Level[16, 14], Level[16, 15], Level[16, 16], Level[16, 17], Level[16, 18], Level[16, 19]);

        }
    }
}
