﻿using System;

namespace ColorSpheres
{
    public class Color
    {
        private readonly int red;
        private readonly int green;
        private readonly int blue;        
        private readonly int alpha;

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

        // Method to get grey value
        public int GetGrey()
        {
            return (red + green + blue) / 3;
        }

        // Helper method to clamp values between 0 and 255
        private int Clamp(int value)
        {
            return Math.Max(0, Math.Min(255, value));
        }
    }
}
