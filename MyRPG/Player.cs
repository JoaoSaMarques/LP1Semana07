namespace MyRPG
{
    public class Player
    {
        private string name;
        private int xp;
        private float health;
        
        readonly int level;


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
            }
        }

        public int XP { get { return xp; } }

        // Constructor
        public Player(string name)
        {
            Name = name;
            xp = 0;
            health = MaxHealth;
            level = 1 + xp / 1000;
        }

        public int GetLevel()
        {
            return level;
        }
    }
}
