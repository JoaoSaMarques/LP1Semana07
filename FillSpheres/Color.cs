using System;

namespace FillSpheres
{
    public class Color
    {
        //Colors RGB
        public int Red { get; set }
        public int Green { get; set }
        public int Blue { get; set }


        //Define color
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        
        public Color(int red, int green, int blue) : this(red, green, blue)
        {

        }

    }
}
