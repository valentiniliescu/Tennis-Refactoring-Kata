namespace Tennis
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
        void Player1WonPoint();
        void Player2WonPoint();
    }
}