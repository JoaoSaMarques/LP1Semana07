using System;

namespace BetterFillSpheres
{
    public class Sphere
    {
        public Color color { get; set; }
        public double radius{ get; set; }
        public int numOfTimesThrown;

        //Define the sphere
        public Sphere(Color color, double radius)
        {
            //Color
            this.color = color;
            //Total radius
            this.radius = radius;
            //Times it has been thrown
            this.numOfTimesThrown = 0;
        }

        //Pop method
        public void Pop()
        {
            //Turns sphere radius to 0
            radius = 0;
        }

        //Throw method
        public void Throw()
        {
            //If Sphere hasn't been popped
            if (radius > 0)
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
