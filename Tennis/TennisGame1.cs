using System;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;

        public void WonPoint(TennisPlayer tennisPlayer)
        {
            if (tennisPlayer == TennisPlayer.Player1)
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (m_score1 == m_score2)
            {
                switch (m_score1)
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
            else if (m_score1 >= 4 || m_score2 >= 4)
            {
                var minusResult = m_score1 - m_score2;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1)
                    {
                        tempScore = m_score1;
                    }
                    else
                    {
                        score += "-";
                        tempScore = m_score2;
                    }
                    score += ConvertScoreToString(tempScore);
                }
            }
            return score;
        }

        private static string ConvertScoreToString(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
            }
            throw new ArgumentException("score");
        }
    }
}

