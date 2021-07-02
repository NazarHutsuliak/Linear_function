using LinearLibrary;
using Xunit;

namespace LinearFunctionTests
{
    public class SameCoordinatesTests
    {
        [Fact]
        public void y_is_equal_x()
        {
            // Arrange
            const string expected = "y = x";
            // Act
            var actual = new LinearFunction(new Coordinates(1, 1, 2, 2)).ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void parallel_OY_same_x1_4_x2_4_Result_The_function_is_parallel_x_4()
        {
            // Arrange
            const string expected = "x = 4";
            // Act
            var actual = new LinearFunction(new Coordinates(4, 0, 4, 2)).ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void parallel_OX_Test_same_y1_5_y2_5_Result_The_function_is_parallel_y_5()
        {
            // Arrange
            const string expected = "y = 5";
            // Act
            var actual = new LinearFunction(new Coordinates(8, 5, 22, 5)).ToString();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
