namespace Tennis
{
    internal class TennisGame1 : ITennisGame
    {
        private int _scorePlayer1;
        private int _scorePlayer2;

        public string GetScore()
        {
            var score = "";
            if (_scorePlayer1 == _scorePlayer2)
            {
                switch (_scorePlayer1)
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
            else if (_scorePlayer1 >= 4 || _scorePlayer2 >= 4)
            {
                var scoreDifference = _scorePlayer1 - _scorePlayer2;
                if (scoreDifference == 1) score = "Advantage player1";
                else if (scoreDifference == -1) score = "Advantage player2";
                else if (scoreDifference >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    int tempScore;
                    if (i == 1)
                    {
                        tempScore = _scorePlayer1;
                    }
                    else
                    {
                        score += "-";
                        tempScore = _scorePlayer2;
                    }
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
            _scorePlayer1 += 1;
        }

        public void Player2WonPoint()
        {
            _scorePlayer2 += 1;
        }
    }
}