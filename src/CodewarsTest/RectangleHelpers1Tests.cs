using Codewars;

namespace CodewarsTest
{
    public class RectangleHelpers1Tests
    {
        [Test, Order(1)]
        public void HasIntersectionReturnsFalse()
        {
            var rect1 = new Rect(0, 0, 1, 1);
            var rect2 = new Rect(2, 2, 3, 3);

            bool result = RectangleHelpers1.HasIntersection(rect1, rect2);

            Assert.That(result, Is.False);
        }

        [Test, Order(2)]
        public void HasIntersectionReturnsTrue()
        {
            var rect1 = new Rect(0, 0, 3, 3);
            var rect2 = new Rect(1, 1, 3, 3);

            bool result = RectangleHelpers1.HasIntersection(rect1, rect2);

            Assert.That(result, Is.True);
        }

        [Test, Order(3)]
        public void GetAreaReturnsExpectedResult()
        {
            var rect = new Rect(0, 0, 3, 3);
            var expectedResult = 9;

            int result = RectangleHelpers1.GetArea(rect);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test, Order(4)]
        public void GetIntersectionAreaReturnsExpectedResult()
        {
            var rect1 = new Rect(0, 0, 3, 3);
            var rect2 = new Rect(1, 1, 4, 2);
            var expectedResult = 2;

            int result = RectangleHelpers1.GetIntersectionArea(rect1, rect2);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
