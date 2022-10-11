using SCalc;

namespace SCalcTest
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void GetAreaByBaseAndHeight() =>
            Assert.That(new Triangle(4, 3.4).GetArea(), Is.EqualTo(6.8));

        [Test]
        public void GetAreaByThreeSides() =>
            Assert.That(new Triangle(4, 9, 7).GetArea(), Is.EqualTo(13.42));

        [Test]
        public void TriangleThrowAnArgumentException() =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3), $"triangle a-side should be greather than zero.");
    }
}