using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit 
    {
        public int BaseHealth { get; private set; }
        public int XP { get; private set; }
        public int AttackPower { get; private set; }

        public MilitaryUnit(int baseHealth, int attackPower) : base(baseHealth + XP)
        {
            BaseHealth = baseHealth;
            AttackPower = attackPower;
            XP = 0;
            Cost = AttackPower + XP;
        }

        public override int Health 
        { 
            get { return BaseHealth + XP; }
        }

        public override float Cost 
        { 
            get { return AttackPower + XP; }
        }

        public void Attack(Unit target) 
        {
            target.Health -= AttackPower;
            XP++;
        }
    }
}