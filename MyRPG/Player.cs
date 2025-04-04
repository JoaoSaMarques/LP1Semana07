namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;
        
        public int Level => 1 + xp / 1000;

        readonly float MaxHealth;

        private int damage;


        readonly string Name { get; }
        public int Level { get; }
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

        public int Damage { get { return damage; } }

        public int XP { get { return xp; } }

        // Constructor
        public Player(string name)
        {
            Name = name;
            xp = 0;
            Health = MaxHealth;
        }

        public void TakeDamage(float damage)
        {
            health -= damage;

        }
    }
}
