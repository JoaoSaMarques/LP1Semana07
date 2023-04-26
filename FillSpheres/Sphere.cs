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

        //Pop method
        public void Pop()
        {
            //Turns sphere radius to 0
            this.radius = 0;
        }

        //Throw method
        public void Throw()
        {
            //If Sphere hasn't been popped
            if (this.radius > 0)
            {
                //increase number of times it has been thrown
                this.timesThrown++;
            }
        }



    }
}
