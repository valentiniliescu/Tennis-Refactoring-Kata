using Tennis.Models;

namespace Tennis
{
    public interface ITennisGame
    {
        string GetScore();
        Player Player1 { get; }
        Player Player2 { get; }
    }
}

