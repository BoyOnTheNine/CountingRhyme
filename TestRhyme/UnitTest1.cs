using ConsoleApp1;

namespace TestRhyme
{

    [TestClass]
    public class ChildrenCircleTests
    {
        [TestMethod]
        public void FindLastRemainingChild_WithPositiveNM_ReturnsCorrectResult()
        {
            // Arrange
            int N = 10;
            int M = 3;
            CountingRhyme counting = new CountingRhyme();

            // Act
            int lastRemainingChild = counting.GetLastRemaining(N, M);

            // Assert
            Assert.AreEqual(4, lastRemainingChild);
        }

        [TestMethod]
        public void FindLastRemainingChild_WithNMEqualsN()
        {
            // Arrange
            int N = 8;
            int M = 8;
            CountingRhyme counting = new CountingRhyme();

            // Act
            int lastRemainingChild = counting.GetLastRemaining(N, M);

            // Assert
            Assert.AreEqual(4, lastRemainingChild);
        }

        [TestMethod]
        public void FindLastRemainingChild_WithNLessThanM()
        {
            // Arrange
            int N = 3;
            int M = 5;
            CountingRhyme counting = new CountingRhyme();

            // Act
            int lastRemainingChild = counting.GetLastRemaining(N, M);

            // Assert
            Assert.AreEqual(1, lastRemainingChild);
        }
    }
}