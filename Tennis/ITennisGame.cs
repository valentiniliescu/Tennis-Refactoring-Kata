using Tennis.Models;

namespace Tennis
{
    public interface ITennisGame
    {
        string GetScore();
        void Player1WonPoint();
        void Player2WonPoint();
        Player Player1 { get; }
        Player Player2 { get; }
    }
}

