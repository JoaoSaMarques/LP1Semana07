using System;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        public SpyUnit() : base(8, 2)
        {
            Cost = 12.5f;
        }

        public override float Cost { get; set; }

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