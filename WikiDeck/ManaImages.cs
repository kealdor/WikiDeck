using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiDeck
{
    public static class ManaImages
    {
        public static Bitmap GetImage(string code)
        {
            switch (code)
            {
                case "R":
                    return Properties.Resources.Color_R;
                case "G":
                    return Properties.Resources.Color_G;
                case "B":
                    return Properties.Resources.Color_B;
                case "U":
                    return Properties.Resources.Color_U;
                case "W":
                    return Properties.Resources.Color_W;
                case "C":
                    return Properties.Resources.Mana_C;
                case "X":
                    return Properties.Resources.CMCX;
                case "0":
                    return Properties.Resources.CMC0;
                case "1":
                    return Properties.Resources.CMC1;
                case "2":
                    return Properties.Resources.CMC2;
                case "3":
                    return Properties.Resources.CMC3;
                case "4":
                    return Properties.Resources.CMC4;
                case "5":
                    return Properties.Resources.CMC5;
                case "6":
                    return Properties.Resources.CMC6;
                case "7":
                    return Properties.Resources.CMC7;
                case "8":
                    return Properties.Resources.CMC8;
                case "9":
                    return Properties.Resources.CMC9;
                case "10":
                    return Properties.Resources.CMC10;
                case "11":
                    return Properties.Resources.CMC11;
                default:
                    // TODO: proper exception
                    throw new Exception("Invalid mana image code \"" + code +"\"");
            }
        }
    }
}
