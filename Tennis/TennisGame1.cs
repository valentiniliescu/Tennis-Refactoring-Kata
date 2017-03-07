using System;
using Tennis.Models;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private Player m_player1;
        private Player m_player2;

        public TennisGame1(Player player1, Player player2)
        {
            m_player1 = player1;
            m_player2 = player2;
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (m_player1.Score == m_player2.Score)
            {
                switch (m_player1.Score)
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
            else if (m_player1.Score >= 4 || m_player2.Score >= 4)
            {
                var minusResult = m_player1.Score - m_player2.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = m_player1.Score;
                    else { score += "-"; tempScore = m_player2.Score; }
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

        public void Player1WonPoint()
        {
            m_player1.WonPoint();
        }

        public void Player2WonPoint()
        {
            m_player2.WonPoint();
        }
    }
}

