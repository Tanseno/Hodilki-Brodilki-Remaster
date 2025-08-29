using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodilki_brodilki
{
    public class Player
    {
        private static int[] Pos = new int[] { 9, 14 };
        private static string Skin = "@";
        private static int Balance = 0;

        //public Player(int[] Pos, string Skin)
        //{
        //    this.Pos = Pos;
        //    this.Skin = Skin;
        //}
        //public Player(string Skin)
        //{
        //    this.Skin = Skin;
        //}
        //public Player(int[] Pos)
        //{
        //    this.Pos = Pos;
        //}
        //public Player(){}

        public static void Switch_Pos(int[] Pos1)
        {
            Pos = Pos1;
        }
        public static void Switch_Skin(string Skin1)
        {
            Skin = Skin1;
        }

        public static void Go_Left()
        {
            Pos[0] -= 1;
        }
        public static void Go_Right()
        {
            Pos[0] += 1;
        }
        public static void Go_Ahead()
        {
            Pos[1] -= 1;
        }
        public static void Go_Back()
        {
            Pos[1] += 1;
        }


        public static int Get_Pos_Y()
        {
            return Pos[0];
        }
        public static int Get_Pos_X()
        {
            return Pos[1];
        }
        public static int[] Get_Pos()
        {
            return Pos;
        }
        public static string Get_Skin()
        {
            return Skin;
        }

        public static void New_Coin()
        {
            Balance++;
        }
    }
}
