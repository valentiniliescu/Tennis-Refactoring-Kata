﻿namespace Tennis.Models
{
    public class Player
    {
        public string Name { get; }

        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public void WonPoint()
        {
            Score++;
        }
    }
}
