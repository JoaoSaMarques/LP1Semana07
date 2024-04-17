using System;

namespace GameUnits
{
    public class Program
    {
        public static void Main()
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit military = new MilitaryUnit(5);

            Console.WriteLine("Settler Unit:");
            settler.Move();
            Console.WriteLine($"Health: {settler.Health}");
            Console.WriteLine($"Cost: {settler.Cost}");

            Console.WriteLine("Military Unit:");
            military.Move();
            Console.WriteLine($"Health: {military.Health}");
            Console.WriteLine($"Cost: {military.Cost}");
        }
    }
}