using NUnit.Framework;
using Tennis.Models;

namespace Tennis
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void PlayerShouldHaveAName()
        {
            var player = new Player("player1");

            Assert.AreEqual("player1", player.Name);
        }

        [Test]
        public void PlayerShouldStartWithZeroPoints()
        {
            var player = new Player("player1");
            
            Assert.AreEqual(0, player.Points);
        }

        [Test]
        public void WinningAPointShouldIncrementThePoints()
        {
            var player = new Player("player1");

            player.WonPoint();

            Assert.AreEqual(1, player.Points);
        }
    }
}

