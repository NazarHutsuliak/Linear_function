using Xunit;
using LinearLibrary;

namespace LinearFunctionTests
{
    public class AnswerLineFunctionTests
    {
        [Fact]
        public void x1_min2_y2_4_x2_2_y2_min10_Result_y_is_equal_minus_3whole_1num_2denum_x_minus_3()
        {
            // Arrange
            const string expected = "y = - 3 1/2 * x - 3 ";
            // Act
            var actual = new LinearFunction(new Coordinates(-2, 4, 2, -10)).ToString();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void x1_5_y2_4_x2_1_y2_2_Result_string_y_is_equal_1num_2denum_x_plus_1whole_1num_2denum()
        {
            // Arrange
            const string expected = "y = 1/2 * x + 1 1/2 ";
            // Act
            var actual = new LinearFunction(new Coordinates(5, 4, 1, 2)).ToString();
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
