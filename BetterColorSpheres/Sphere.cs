using System;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Color { get; }
        public double Radius { get; private set; }
        public int TimesThrown { get; private set; }

        // Constructor
        public Sphere(Color color, double radius)
        {
            Color = color;
            Radius = radius;
            TimesThrown = 0;
        }

        // Method to pop the sphere
        public void Pop()
        {
            Radius = 0;
        }

        // Method to throw the sphere
        public void Throw()
        {
            if (Radius > 0)
            {
                TimesThrown++;
            }
        }

        // Method to get the radius of the sphere
        public double GetRadius()
        {
            return Radius;
        }
    }
}