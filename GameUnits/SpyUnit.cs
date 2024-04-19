using System;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public SpyUnit() : base(8, 2)
        {
            Cost = 12.5;
        }

        public double Cost { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + " Cost: " + Cost;
        }

        public void GetSecretInfo(Unit unit)
        {
            if (unit is SpyUnit)
            {
                XP += 3;
            }
            
            if (unit is MilitaryUnit)
            {
                XP += 2;
            }

            else
            {
                XP += 1;
            }
        }
    }
}