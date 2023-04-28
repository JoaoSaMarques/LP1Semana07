using System;

namespace PlayerStats
{
    public class Player
    {
        //stats
        //HighScore
        public float highScore;
        //Amount of games played
        public int playedGames;
        //Games won
        public int wonGames;
        //String name
        public readonly string name;

        //High Score
        public float HighScore
        {
            get { return highScore; }
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

        //Get Name
        public string Name
        {
        get { return name; }
        }

        //Get WinRate
        public float WinRate
        {
        get { return playedGames == 0 ? 0 : (float)wonGames / playedGames; }
        }

        //Constructor to create player stats
        public Player(string name)
        {
            this.name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }


    }
}
