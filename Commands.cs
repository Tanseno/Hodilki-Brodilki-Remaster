using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodilki_brodilki
{
    public static class Commands
    {
        public static void Analysis(string Line)
        {
            if (Line.Length == 1)
            {
                One_symbol(Line);
                // Map.Message(Line);
                // Map.Draw_Level();
            }
            else
            {
                Lots_Of_Symbol(Line);
            }
        }

        public static void One_symbol(string Line)
        {
            Map.Player_Invisible();
            switch (Line)
            {
                case "w":
                    try
                    {
                        if (Map.Check_Ahead() == ".")
                        {
                            Player.Go_Ahead();
                        }
                        else if (Map.Check_Ahead() == "$")
                        {
                            Player.Go_Ahead();
                            Player.New_Coin();
                        }
                    }
                    catch (Exception) { }
                    break;



                case "s":
                    try
                    {
                        if (Map.Check_Back() == ".")
                        {
                            Player.Go_Back();
                        }
                        else if (Map.Check_Back() == "$")
                        {
                            Player.Go_Back();
                            Player.New_Coin();
                        }
                    }
                    catch (Exception) { }
                    break;



                case "d":
                    try
                    {
                        if (Map.Check_Right() == ".")
                        {
                            Player.Go_Right();
                        }
                        else if (Map.Check_Right() == "$")
                        {
                            Player.Go_Right();
                            Player.New_Coin();
                        }
                    }
                    catch (Exception) { }
                    break;



                case "a":
                    try
                    {
                        if (Map.Check_Left() == ".")
                        {
                            Player.Go_Left();
                        }
                        else if (Map.Check_Left() == "$")
                        {
                            Player.Go_Left();
                            Player.New_Coin();
                        }
                    }
                    catch (Exception) { }
                    break;



                case "e":
                    break;



                case "":
                    break;



            }
            Map.Player_Not_Invisible();
            Map.Draw_Level();
        }
        





        public static void Lots_Of_Symbol(string Line)
        {
            string[] Words = Line.Split(' ');
            switch (Words[0])
            {
                case "!load":
                    // Map.Load_Level(Words[1]);
                    System.Console.WriteLine("Не работает");
                    break;


                    
                case "!position":
                    System.Console.WriteLine("X: " + Player.Get_Pos_X() + ", Y: " + Player.Get_Pos_Y());
                    break;
            }
        }
    }
}
