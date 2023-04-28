using System;

namespace PlayerStats
{
    public class Player
    {
        //stats
        //HighScore
        public float highScore { get; set; }
        //Amount of games played
        public int playedGames { get; set; }
        //Games won
        public int wonGames { get; set; }
        //String name
        public readonly string name;

        //Player stats
        public Player(float HighScore)
        {
            highScore = HighScore
        }

        




    }
}
