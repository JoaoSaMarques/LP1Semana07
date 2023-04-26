using System;

namespace FillSpheres
{
    public class Color
    {
        //Colors RGB
        public int Red { get; set }
        public int Green { get; set }


        //Define color
        public Color(int red, int green)
        {
            Red = red;
            Green = green;
        }

        
        public Color(int red, int green) : this(red, green)
        {

        }

    }
}
