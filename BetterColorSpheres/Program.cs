using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");

            // Create some colors
            Color redColor = new Color(255, 0, 0);
            Color greenColor = new Color(0, 255, 0);
            Color blueColor = new Color(0, 0, 255);

            // Create spheres
            Sphere redSphere = new Sphere(redColor, 5.0);
            Sphere greenSphere = new Sphere(greenColor, 10.0);

            // Throw the spheres
            redSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();

            // Pop the red sphere
            redSphere.Pop();

            // Print the state of the spheres
            // Print the state of the spheres
            Console.WriteLine($"R Sphere - Radius: {redSphere.GetRadius()}, "+
                              $"Times Thrown: {redSphere.TimesThrown}, " +
                              $"Color: ({redSphere.Color.Red}, " +
                              $"{redSphere.Color.Green}, " +
                              $"{redSphere.Color.Blue})");
            Console.WriteLine($"G Sphere - Radius: {greenSphere.GetRadius()}, "+
                              $"Times Thrown: {greenSphere.TimesThrown}, " +
                              $"Color: ({greenSphere.Color.Red}, " +
                              $"{greenSphere.Color.Green}, " +
                              $"{greenSphere.Color.Blue})");
        }
    }
}
