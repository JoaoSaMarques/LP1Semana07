using System;

namespace FillSpheres
{
    public class Sphere
    {
        private Color color;
        private double radius;
        private int numOfTimesThrown;

        //Define the sphere
        public Sphere(Color color, double radius)
        {
            //Color
            this.color = color;
            //Total radius
            this.radius = radius;
            //Times it has been thrown
            this.timesThrown = 0;
        }



    }
}
