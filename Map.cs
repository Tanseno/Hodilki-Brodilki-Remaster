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
        private static int[] Pos = new int[] { 0, 0 };

        private static string[,] Level = {                                                                                                 // карта (Level)                          
            { "1", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "."},
            { ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "2"},

            };

        public static void Pos_On_Map()
        {
            Pos = Player.Get_Pos();
        }

        public static void Message(string Word)
        { 
            // Level[Player.Get_Pos_X(), Player.Get_Pos_Y()] = ".";
            // switch (Word)
            // {
            //     case "w":
            //         try
            //         {
            //             if (Check_Ahead(Level) == ".")
            //             {
            //                 Player.Go_Ahead();
            //             }
            //             else if (Check_Ahead(Level) == "$")
            //             {
            //                 Player.Go_Ahead();
            //                 Player.New_Coin();
            //             }
            //         }
            //         catch (Exception) { }
            //         break;



            //     case "s":
            //         try
            //         {
            //             if (Check_Back(Level) == ".")
            //             {
            //                 Player.Go_Back();
            //             }
            //             else if (Check_Back(Level) == "$")
            //             {
            //                 Player.Go_Back();
            //                 Player.New_Coin();
            //             }
            //         }
            //         catch (Exception) { }
            //         break;



            //     case "d":
            //         try
            //         {
            //             if (Check_Right(Level) == ".")
            //             {
            //                 Player.Go_Right();
            //             }
            //             else if (Check_Right(Level) == "$")
            //             {
            //                 Player.Go_Right();
            //                 Player.New_Coin();
            //             }
            //         }
            //         catch (Exception) { }
            //         break;



            //     case "a":
            //         try
            //         {
            //             if (Check_Left(Level) == ".")
            //             {
            //                 Player.Go_Left();
            //             }
            //             else if (Check_Left(Level) == "$")
            //             {
            //                 Player.Go_Left();
            //                 Player.New_Coin();
            //             }
            //         }
            //         catch (Exception) { }
            //         break;



            //     case "e":
            //         break;



            //     case "":
            //         break;
                    


            //     }
            // Level[Player.Get_Pos_X(), Player.Get_Pos_Y()] = Player.Get_Skin();            
        }

        public static string Check_Left()
        {
            string Square = Level[Player.Get_Pos_X(), Player.Get_Pos_Y() - 1];
            return Square;
        }
        public static string Check_Right()
        {
            string Square = Level[Player.Get_Pos_X(), Player.Get_Pos_Y() + 1];
            return Square;
        }
        public static string Check_Ahead()
        {
            string Square = Level[Player.Get_Pos_X() - 1, Player.Get_Pos_Y()];
            return Square;
        }
        public static string Check_Back()
        {
            string Square = Level[Player.Get_Pos_X() + 1, Player.Get_Pos_Y()];
            return Square;
        }

        public static void Player_Invisible()   // Duran Duran - Invisible
        {
            Level[Player.Get_Pos_X(), Player.Get_Pos_Y()] = ".";
        }
        public static void Player_Not_Invisible()
        {
            Level[Player.Get_Pos_X(), Player.Get_Pos_Y()] = Player.Get_Skin();
        }
        


        public static void Load_Level(string Name_File_Txt)
        {
            using (StreamReader text = new StreamReader(Name_File_Txt))
            {
                int i = 0;
                string line = text.ReadToEnd();
                string[] info = line.Split('\n');

                string[] Pos_On_The_Load_Map = info[15].Split(' ');
                int X_Player = Convert.ToInt32(Pos_On_The_Load_Map[0]);
                int Y_Player = Convert.ToInt32(Pos_On_The_Load_Map[1]);
                Player.Switch_Pos(new int[] { Y_Player, X_Player });
                Pos = new int[] { Y_Player, X_Player };

                string Player_Skin = info[16];
                Player.Switch_Skin(Convert.ToString(Player_Skin[0]));
                for (int y = 2; y <= 16; y++)
                {
                    for (int x = 5; x <= 19; x++)
                    {
                        if (line[i] != '\n' && line[i] != ' ')
                        {
                            Level[y, x] = Convert.ToString(line[i]);
                        }
                        else
                        {
                            x = 4;
                        }
                        i++;
                    }
                }
                Level[Y_Player, X_Player] = "@";
                Draw_Level();
            }
        }

        public static void Draw_Level()
        {
            System.Console.WriteLine("");
            for(int y = 0; y <= 14; y++)
            {
                for(int x = 0; x <= 14; x++)
                {
                    Console.Write(Level[y,x]);
                    if(Level[y, x] == "#")
                    {
                        Pos[0] = y;
                        Pos[1] = x;
                    }
                }
                Console.WriteLine("\n");
            }
            System.Console.WriteLine("");
        }
    }
}
