using Xunit;

namespace GameOfLife.Tests
{
    public class GameTests
    {
        [Fact]
        public void ShouldBeAbleToStart()
        {
            Game.Start();
        }
    }
}