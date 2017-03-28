using NUnit.Framework;
using Tennis.Models;

namespace Tennis
{
    [TestFixture]
    public class GameTests
    {
        private static TennisGame1 CreateGameWithPlayerPoints(int player1InitialPoints, int player2InitialPoints)
        {
            var player1 = new Player("player1", player1InitialPoints);
            var player2 = new Player("player2", player2InitialPoints);

            return new TennisGame1(player1, player2);
        }

        [Test]
        public void LoveAll()
        {
            var game = CreateGameWithPlayerPoints(0, 0);

            Assert.AreEqual("Love-All", game.GetScore());
        }

        [Test]
        public void Deuce()
        {
            var game = CreateGameWithPlayerPoints(3, 3);

            Assert.AreEqual("Deuce", game.GetScore());
        }

        [Test]
        public void Advantage()
        {
            var game = CreateGameWithPlayerPoints(4, 3);

            Assert.AreEqual("Advantage player1", game.GetScore());
        }

        [Test]
        public void WinInAdvantageScoring()
        {
            var game = CreateGameWithPlayerPoints(5, 3);

            Assert.AreEqual("Win for player1", game.GetScore());
        }

        [Test]
        public void WinWithMoreThan2Points()
        {
            var game = CreateGameWithPlayerPoints(4, 0);

            Assert.AreEqual("Win for player1", game.GetScore());
        }

        [Test]
        public void FifteenLove()
        {
            var game = CreateGameWithPlayerPoints(1, 0);

            Assert.AreEqual("Fifteen-Love", game.GetScore());
        }
    }
}