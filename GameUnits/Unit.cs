using System;

namespace GameUnits
{
    public abstract class Unit
    {
        public int Movement { get; protected set; }
        public virtual float Health { get; set; }
        public abstract float Cost { get; }

        public void Move()
        {
            Console.WriteLine($"Unit moved {Movement} spaces.");
        }
    }
}