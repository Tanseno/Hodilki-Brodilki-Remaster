using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodilki_brodilki
{
    public class Player
    {
        private int[] Pos = new int[] { 9, 14 };
        private string Skin = "@";

        public Player(int[] Pos, string Skin)
        {
            this.Pos = Pos;
            this.Skin = Skin;
        }
        public Player(string Skin)
        {
            this.Skin = Skin;
        }
        public Player(int[] Pos)
        {
            this.Pos = Pos;
        }
        public Player(){}


        public void Go_Left()
        {
            Pos[0] -= 1;
        }
        public void Go_Right()
        {
            Pos[0] += 1;
        }
        public void Go_Ahead()
        {
            Pos[1] -= 1;
        }
        public void Go_Back()
        {
            Pos[1] += 1;
        }
        public int Get_Pos_Y()
        {
            return Pos[0];
        }
        public int Get_Pos_X()
        {
            return Pos[1];
        }
    }
}
