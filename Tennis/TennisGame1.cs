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
            var tempScore = 0;
            if (Player1.Score == Player2.Score)
            {
                switch (Player1.Score)
                {
                    case 0:
                        score = "Love-All";
                        break;
                    case 1:
                        score = "Fifteen-All";
                        break;
                    case 2:
                        score = "Thirty-All";
                        break;
                    default:
                        score = "Deuce";
                        break;

                }
            }
            else if (Player1.Score >= 4 || Player2.Score >= 4)
            {
                var minusResult = Player1.Score - Player2.Score;
                if (minusResult == 1) score = $"Advantage {Player1.Name}";
                else if (minusResult == -1) score = $"Advantage {Player2.Name}";
                else if (minusResult >= 2) score = $"Win for {Player1.Name}";
                else score = $"Win for {Player2.Name}";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = Player1.Score;
                    else { score += "-"; tempScore = Player2.Score; }
                    switch (tempScore)
                    {
                        case 0:
                            score += "Love";
                            break;
                        case 1:
                            score += "Fifteen";
                            break;
                        case 2:
                            score += "Thirty";
                            break;
                        case 3:
                            score += "Forty";
                            break;
                    }
                }
            }
            return score;
        }
    }
}

