namespace MyRPG
{
    public class Player
    {
        readonly string name;
        private int xp;
        private float health;
        
        readonly int level;


        public string Name { get; }

        // Constructor
        public Player(string name, int xp, float health, int level)
        {
            Name = name;
            this.xp = xp;
            this.health = health;
            this.level = level;
        }

        public GetHealth()
    }
}
