using System;

namespace GameUnits
{
    public abstract class Unit
    {
        public int Movement { get; protected set; }
        public virtual int Health { get; set; }
        public virtual float Cost { get; set; }

        public Unit(int health, float cost)
        {
            Health = health;
            Cost = cost;
        }

        public void Move()
        {
            Console.WriteLine($"Unit moved {Movement} spaces.");
        }

        public void DecreaseHealth(int amount)
        {
            Health -= amount;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost.ToString("F2")}";
        }
    }
}