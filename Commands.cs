using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodilki_brodilki
{
    public static class Commands
    {
        public static void Analysis(string line)
        {
            string[] words = line.Split(' ');
            switch (words[0])
            {
                case "!load":
                    Map.Load_Level(words[1]);
                    break;
            }
        }
    }
}
