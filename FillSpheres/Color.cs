using System;

namespace FillSpheres
{
    public class Color
    {
        //Colors RGB
        public int Red { get; set }
        public int Green { get; set }
        public int Blue { get; set }
        public int Alpha { get; set }


        //Define color
        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        
        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {

        }

    }
}
