using Codewars;

namespace CodewarsTest
{
    [TestFixture, Order(1)]
    public class RectangleCalculationTests
    {
        [Test, Order(1)]
        public void ZeroRectangles()
        {
            Assert.That(RectangleCalculation.Calculate(
                Enumerable.Empty<int[]>()), 
                Is.EqualTo(0));
        }

        [Test, Order(2)]
        public void OneRectangle()
        {
            Assert.That(RectangleCalculation.Calculate([ 
                [0, 0, 1, 1] 
            ]), Is.EqualTo(1));
        }

        [Test, Order(3)]
        public void OneRectangleV2()
        {
            Assert.That(RectangleCalculation.Calculate([ 
                [0, 4, 11, 6] 
            ]), Is.EqualTo(22));
        }

        [Test, Order(4)]
        public void TwoRectangles()
        {
            Assert.That(RectangleCalculation.Calculate([ 
                [0, 0, 1, 1], 
                [1, 1, 2, 2] 
            ]), Is.EqualTo(2));
        }

        [Test, Order(5)]
        public void TwoRectanglesV2()
        {
            Assert.That(RectangleCalculation.Calculate([ 
                [0, 0, 1, 1], 
                [0, 0, 2, 2] 
            ]), Is.EqualTo(4));
        }

        [Test, Order(6)]
        public void ThreeRectangles()
        {
            Assert.That(RectangleCalculation.Calculate([ 
                [3, 3, 8, 5], 
                [6, 3, 8, 9], 
                [11, 6, 14, 12] 
            ]), Is.EqualTo(36));
        }
    }
}