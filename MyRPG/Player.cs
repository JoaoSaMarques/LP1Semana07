namespace MyRPG
{
    public class Player
    {
        private int xp;
        private float health;


        public string Name { get; }

        // Constructor
        public Player(string name)
        {
            Name = name;
            xp = 0;
            health = 100f + (xp-1)*20;
        }
    }
}
