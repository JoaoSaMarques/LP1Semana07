using System;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private double radius;
        private int timesThrown;

        // Constructor
        public Sphere(Color color, double radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }
    }
}
