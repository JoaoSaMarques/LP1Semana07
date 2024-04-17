using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit();
            MilitaryUnit military = new MilitaryUnit(100, 10);

            settler.Move();
            Console.WriteLine($"SettlerUnit Health: {settler.Health}");
            Console.WriteLine($"SettlerUnit Cost: {settler.Cost}");

            military.Move();
            Console.WriteLine($"MilitaryUnit Health: {military.Health}");
            Console.WriteLine($"MilitaryUnit Cost: {military.Cost}");

            military.Attack(settler);

            Console.WriteLine($"SettlerUnit Health after attack: {settler.Health}");
            Console.WriteLine($"MilitaryUnit Health after attack: {military.Health}");
            Console.WriteLine($"MilitaryUnit XP after attack: {military.XP}");
        }
    }
}