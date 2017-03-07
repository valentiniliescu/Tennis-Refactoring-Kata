using Tennis.Models;

namespace Tennis
{
    public interface ITennisGame
    {
        void WonPoint(Player player);
        string GetScore();
    }
}

