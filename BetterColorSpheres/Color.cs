using System;

namespace BetterColorSpheres
{
    public class Color
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
        public int Alpha { get; }

        // Constructor with all parameters
        public Color(int red, int green, int blue, int alpha)
        {
            Red = Clamp(red);
            Green = Clamp(green);
            Blue = Clamp(blue);
            Alpha = Clamp(alpha);
        }

        // Constructor with RGB, alpha defaults to 255
        public Color(int red, int green, int blue) 
            : this(red, green, blue, 255) { }

        // Method to get grey value
        public int GetGrey()
        {
            return (Red + Green + Blue) / 3;
        }

        // Helper method to clamp values between 0 and 255
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
    }
}