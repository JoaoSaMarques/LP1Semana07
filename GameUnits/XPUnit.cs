using System;

namespace GameUnits
{
    public class XPUnit : Unit
    {
        public XPUnit(int movement, int health) : base(movement, health)
        {
            XP = 0;
        }

        public int XP { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + " XP=" + XP;
        }
    }
}