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

        public void Attack(Unit unitToAttack)
        {
            XP++;
            if (unitToAttack is MilitaryUnit militaryUnit)
            {
                militaryUnit.Health--;
            }
            else
            {
                unitToAttack.Health--;
            }
        }
    }
}