using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; private set; }
        public int XP { get; private set; }

        public MilitaryUnit(int attackPower)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public override float Health { get { return base.Health + XP; } }

        public override float Cost { get { return AttackPower + XP; } }

        public void Attack()
        {
            XP++;
            DecreaseHealth(1);
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }
    }
}