using System;

namespace ColorSpheres
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        // Constructor with all parameters
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = Clamp(red);
            this.green = Clamp(green);
            this.blue = Clamp(blue);
            this.alpha = Clamp(alpha);
        }

        // Constructor with RGB, alpha defaults to 255
        public Color(int red, int green, int blue) 
        : this(red, green, blue, 255) { }

        // Getters
        public int Red => red;
        public int Green => green;
        public int Blue => blue;
        public int Alpha => alpha;

        // Helper method to clamp values between 0 and 255
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
    }
}
