using LinearLibrary;
using Xunit;

namespace LinearFunctionTests
{
    public class FractionMethodTests
    {
        [Fact]
        public void GreatestCommonDivisor()
        {
            // Act
            var actual = new Fraction(0, 4, 12).GreatestCommonDivisor(4, 12).ToString();

            // Assert
            Assert.Equal("4", actual);
        }
    }
}
