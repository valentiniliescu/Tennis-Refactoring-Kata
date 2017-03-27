using System.Linq;
using NUnit.Framework;
using Tennis.Models;

namespace Tennis
{
    [TestFixture]
    public class GameTests
    {
        private static TennisGame1 CreateGame()
        {
            var player1 = new Player("player1");
            var player2 = new Player("player2");

            return new TennisGame1(player1, player2);
        }

        private static TennisGame1 CreateGameAndGetToDeuce()
        {
            var game = CreateGame();

            Enumerable.Range(0, 3).ToList().ForEach(i =>
            {
                game.Player1.WonPoint();
                game.Player2.WonPoint();
            });

            return game;
        }

        [Test]
        public void LoveAll()
        {
            var game = CreateGame();

            Assert.AreEqual("Love-All", game.GetScore());
        }

        [Test]
        public void Deuce()
        {
            var game = CreateGameAndGetToDeuce();

            Assert.AreEqual("Deuce", game.GetScore());
        }

        [Test]
        public void Advantage()
        {
            var game = CreateGameAndGetToDeuce();

            game.Player1.WonPoint();

            Assert.AreEqual("Advantage player1", game.GetScore());
        }

        [Test]
        public void WinInAdvantageScoring()
        {
            var game = CreateGameAndGetToDeuce();

            game.Player1.WonPoint();
            game.Player1.WonPoint();

            Assert.AreEqual("Win for player1", game.GetScore());
        }

        [Test]
        public void WinWithMoreThan2Points()
        {
            var game = CreateGame();

            game.Player1.WonPoint();
            game.Player1.WonPoint();
            game.Player1.WonPoint();
            game.Player1.WonPoint();

            Assert.AreEqual("Win for player1", game.GetScore());
        }

        [Test]
        public void FifteenLove()
        {
            var game = CreateGame();

            game.Player1.WonPoint();

            Assert.AreEqual("Fifteen-Love", game.GetScore());
        }
    }
}