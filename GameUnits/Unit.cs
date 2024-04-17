using System;

namespace GameUnits
{
    public abstract class Unit 
    {
        public virtual int Health { get; protected set; }
        public abstract float Cost { get; }

        public Unit(int health) 
        {
            Health = health;
        }

        public virtual void Move() 
        {
            Console.WriteLine("Unit moved 1 space.");
        }
    }
}