using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit()
        {
            Movement = 1;
            Health = 2;
        }

        public override float Cost { get; } = 5;
    }
}