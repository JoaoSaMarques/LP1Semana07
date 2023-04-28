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
            //gets and returns the HighScore
            get { return highScore; }
            set
            {
                //If the value is higher than the set HighScore
                if (value > highScore)
                {
                    //then convert HighScore to that value
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
            //WinRate depending on Won games divided by played games in %
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

        //To make PlayGame work in program.cs
        public void PlayGame(bool win)
        {
            //PlayedGames goes up by 1.
            playedGames++;
            //If you win:
            if (win)
            {
                //Won games goes up by 1.
                wonGames++;
            }
        }
    }
}
