using System;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; private set; }

        public MilitaryUnit(int health, int cost, int attackPower) : base(health, cost)
        {
            AttackPower = attackPower;
        }

        public override int Health { get { return base.Health + XP; } }

        public override float Cost { get { return AttackPower + XP; } }

        public void Attack(Unit target)
        {
            XP++;
            target.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower}";
        }
    }
}