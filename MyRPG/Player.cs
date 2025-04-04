namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;

        public string Name { get; }

        public int XP 
        { 
            get => xp;
            set
            {
                if (value > xp)
                {
                    xp = value;
                }
            }
        }

        public int Level => 1 + xp / 1000;

        public float MaxHealth => 100 + (Level - 1) * 20;

        public float Health 
        { 
            get => health;
            set
            {
                health = value;
                if (health < 0) health = 0;
                if (health > MaxHealth) health = MaxHealth;
            }
        }

        public Player(string name)
        {
            Name = name;
            xp = 0;
            Health = MaxHealth;
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
            XP += (int)damage / 20;
        }
    }
}