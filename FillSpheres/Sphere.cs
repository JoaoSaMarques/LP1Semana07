using System;

namespace FillSpheres
{
    public class Sphere
    {
        private Color color { get; set; }
        private double radius{ get; set; }
        private int numOfTimesThrown;

        //Define the sphere
        public Sphere(Color color, double radius)
        {
            //Color
            color = color;
            //Total radius
            radius = radius;
            //Times it has been thrown
            this.numOfTimesThrown = 0;
        }

        //Pop method
        public void Pop()
        {
            //Turns sphere radius to 0
            Radius = 0;
        }

        //Throw method
        public void Throw()
        {
            //If Sphere hasn't been popped
            if (Radius > 0)
            {
                //increase number of times it has been thrown
                this.numOfTimesThrown++;
            }
        }

        //get the number of times the ball has been thrown
        public int GetTimesThrown()
        {
            return this.numOfTimesThrown;
        }
    }
}
