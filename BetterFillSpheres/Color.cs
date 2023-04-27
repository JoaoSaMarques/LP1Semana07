using System;

namespace BetterFillSpheres
{
    public class Color
    {
        //Colors RGB
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        //Define color
        public Color(int red, int green, int blue, int alpha)
        {
            //Red is red
            Red = red;
            //Green is green
            Green = green;
            //Blue is blue
            Blue = blue;
            //Alpha is alpha
            Alpha = alpha;
        }

        //Color
        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }

        //Grey
        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }

        //Get the name of the color
        public string GetName()
        {
            if (Red == 255 && Green == 0 && Blue == 0) // Red
            {
                return "Red";
            }
            else if (Red == 0 && Green == 255 && Blue == 0) // Green
            {
                return "Green";
            }
            else if (Red == 0 && Green == 0 && Blue == 255) // Blue
            {
                return "Blue";
            }
            else //Mixed color
            {
                return "Mixed";
            }
        }
    }
}