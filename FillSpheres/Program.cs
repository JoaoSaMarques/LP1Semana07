using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some spheres
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 5);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 10);
            Sphere sphere3 = new Sphere(new Color(0, 0, 255), 15);

            //Throw the spheres around
            //Throwing 2 of each sphere
            sphere1.Throw();
            sphere1.Throw();
            sphere2.Throw();
            sphere2.Throw();
            sphere3.Throw();
            sphere3.Throw();

            //Pop the second sphere
            sphere2.Pop();
        }
    }
}
