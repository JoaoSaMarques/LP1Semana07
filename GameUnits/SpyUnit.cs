using System;

namespace GameUnits
{
    public class SpyUnit: Unit
    {
        public SpyUnit() : base(2, 5)
        {
            Movement = 1;
            Health = 2;
        }

        public override float Health
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