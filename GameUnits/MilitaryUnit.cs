using System;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        public int AttackPower { get; private set; }

        public MilitaryUnit(int attackPower, int health, int cost) : base(health, cost)
        {
            AttackPower = attackPower;
        }

        public override float Health { get { return base.Health + XP; } }

        public override float Cost { get { return AttackPower + XP; } }

        public void Attack(Unit target)
        {
            XP++;
            target.DecreaseHealth(AttackPower);
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }
    }
}