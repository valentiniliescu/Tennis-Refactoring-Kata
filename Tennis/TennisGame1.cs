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
                if (Player1.Points < 3)
                {
                    var player1ScoreLabel = PointScoreLabels.GetScoreLabelForPoints(Player1.Points);
                    score = $"{player1ScoreLabel}-All";
                }
                else
                {
                    score = "Deuce";
                }
            }
            else if (IsAdvantageScoring)
            {
                if (ScoreLead == 1)
                {
                    score = $"Advantage {LeadingPlayer.Name}";
                }
                else
                {
                    score = $"Win for {LeadingPlayer.Name}";
                }
            }
            else
            {
                if (LeadingPlayer.Points == 4)
                {
                    score = $"Win for {LeadingPlayer.Name}";
                }
                else
                {
                    var player1ScoreLabel = PointScoreLabels.GetScoreLabelForPoints(Player1.Points);
                    var player2ScoreLabel = PointScoreLabels.GetScoreLabelForPoints(Player2.Points);
                    score = $"{player1ScoreLabel}-{player2ScoreLabel}";
                } 
            }
            return score;
        }

        private bool IsAdvantageScoring => Player1.Points >= 3 && Player2.Points >= 3;
        private bool IsTie => ScoreLead == 0;
        private int ScoreLead => Math.Abs(Player1.Points - Player2.Points);
        private Player LeadingPlayer => Player1.Points > Player2.Points ? Player1 : Player2;
    }
}

