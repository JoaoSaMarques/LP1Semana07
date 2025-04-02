﻿using System;

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

        // Method to pop the sphere
        public void Pop()
        {
            radius = 0;
        }

        // Method to throw the sphere
        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        // Method to get the number of times thrown
        public int GetTimesThrown()
        {
            return timesThrown;
        }
    }
}
