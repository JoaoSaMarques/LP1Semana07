using System.Text.RegularExpressions;

namespace MyRPG
{
    public class Player
    {
        private string name;
        private int xp;
        private float health;
        
        readonly int level;

        readonly float MaxHealth;

        private int damage;


        readonly string Name { get { return name; } }
        public int Level { get; }
        public float Health 
        { 
            get 
            { 
                return health; 
            } 
            set
            {
                health = value;
                if (health <= 0)
                {
                    health = 0;
                }
                if (health >= MaxHealth)
                {
                    health = MaxHealth;
                }
            }
        }

        public int Damage { get { return damage; } }

        public int XP { get { return xp; } }

        // Constructor
        public Player(string name)
        {
            Name = name;
            xp = 0;
            health = MaxHealth;
            MaxHealth = 100 + (Level -1)*20;
            level = 1 + xp / 1000;
        }

        public void TakeDamage()
        {
            Value = health - damage;
        }
    }
}
