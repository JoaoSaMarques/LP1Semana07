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
            Console.WriteLine($"Sphere 1:");
            Console.WriteLine($"Color = {sphere1.color.GetName()}");
            Console.WriteLine($"Radius = {sphere1.radius},");
            Console.WriteLine($"Times thrown = {sphere1.GetTimesThrown()}");
            //Result for sphere 2
            Console.WriteLine($"\nSphere 2:");
            Console.WriteLine($"Color = {sphere2.color.GetName()}");
            Console.WriteLine($"Radius = {sphere2.radius},");
            Console.WriteLine($"Times thrown = {sphere2.GetTimesThrown()}");
            //Result for sphere 3
            Console.WriteLine($"\nSphere 3:");
            Console.WriteLine($"Color = {sphere3.color.GetName()}");
            Console.WriteLine($"Radius = {sphere3.radius},");
            Console.WriteLine($"Times thrown = {sphere3.GetTimesThrown()}");


        }
    }
}
