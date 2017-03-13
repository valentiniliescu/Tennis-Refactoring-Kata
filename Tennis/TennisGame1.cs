using System;
using Tennis.Models;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        public Player Player1 { get; }
        public Player Player2 { get; }

        public TennisGame1(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public string GetScore()
        {
            string score = "";
            if (IsTie)
            {
                if (Player1.Score < 3)
                {
                    var player1ScoreLabel = ScoreLabels.GetLabelForScore(Player1.Score);
                    score = $"{player1ScoreLabel}-All";
                }
                else
                {
                    score = "Deuce";
                }
            }
            else if (Player1.Score >= 3 && Player2.Score >= 3)
            {
                if (ScoreLead == 1)
                {
                    score = $"Advantage {LeadingPlayer.Name}";
                }
                else if (ScoreLead == 2)
                {
                    score = $"Win for {LeadingPlayer.Name}";
                }
            }
            else
            {
                if (Player1.Score >= 4 || Player2.Score >= 4)
                {
                    score = $"Win for {LeadingPlayer.Name}";
                }
                else
                {
                    var player1ScoreLabel = ScoreLabels.GetLabelForScore(Player1.Score);
                    var player2ScoreLabel = ScoreLabels.GetLabelForScore(Player2.Score);
                    score = $"{player1ScoreLabel}-{player2ScoreLabel}";
                } 
            }
            return score;
        }

        private bool IsTie => ScoreLead == 0;
        private int ScoreLead => Math.Abs(Player1.Score - Player2.Score);
        private Player LeadingPlayer => Player1.Score > Player2.Score ? Player1 : Player2;
    }
}

