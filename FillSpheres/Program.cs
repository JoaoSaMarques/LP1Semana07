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

            //Result for sphere 1
            Console.WriteLine($"Sphere 1: C({sphere1.color.R}, {sphere1.color.G}, {sphere1.color.B}), R{sphere1.radius}, Tt{sphere1.GetTimesThrown()}");
            //Result for sphere 2
            Console.WriteLine($"Sphere 2: C({sphere2.color.R}, {sphere2.color.G}, {sphere2.color.B}), R{sphere2.radius}, Tt{sphere2.GetTimesThrown()}");
            //Result for sphere 3
            Console.WriteLine($"Sphere 3: C({sphere3.color.R}, {sphere3.color.G}, {sphere3.color.B}), R{sphere3.radius}, Tt{sphere3.GetTimesThrown()}");


        }
    }
}
