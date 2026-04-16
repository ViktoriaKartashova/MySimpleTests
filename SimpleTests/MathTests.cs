using NUnit.Framework.Legacy;

namespace SimpleTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        public void Addition_2plus2_Returns4()
        {
            // ARRANGE
            int a = 2;
            int b = 2;
            int expected = 4;

            // ACT
            int result = a + b;

            // ASSERT
            ClassicAssert.AreEqual(expected, result);
        }

        [Test]
        public void Subtraction_5minus3_Returns2()
        {
            int result = 5 - 3;
            ClassicAssert.AreEqual(2, result);
        }

        [Test]
        public void Multiplication_3times4_Returns12()
        {
            int result = 3 * 4;
            ClassicAssert.AreEqual(12, result);
        }
    }
}