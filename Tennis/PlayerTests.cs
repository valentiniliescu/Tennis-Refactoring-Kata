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


    }
}

