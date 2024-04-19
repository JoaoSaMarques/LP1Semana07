using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit() : base(2, 5)
        {
            Movement = 1;
            Health = 3;
        }

        public override int Health
        {
            get { return base.Health; }
            set { base.Health = value; }
        }

        public override float Cost
        {
            get { return base.Cost; }
            set { base.Cost = value; }
        }
    }
}