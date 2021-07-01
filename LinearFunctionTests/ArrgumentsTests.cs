using Xunit;
using LinearLibrary;

namespace LinearFunctionTests
{
    public class LinearTests
    {
        [Fact]
        public void x1_min2_y2_4_x2_2_y2_min10_Result_y_is_equal_minus_3whole_1num_2denum_x_minus_3()
        {
            //Arrange
            const string expected = "y = - 3 1/2 * x - 3";

            //Act
            var actual = new LinearFunction(new Coordinates(-2, 4, 2, -10)).ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void x1_5_y2_4_x2_1_y2_2_Result_string_y_is_equal_1num_2denum_x_plus_1whole_1num_2denum()
        {
            //Arrange
            const string expected = "y = 1/2 * x + 1 1/2";

            //Act
            var actual = new LinearFunction(new Coordinates(5, 4, 1, 2)).ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void parallel_OY_same_x1_4_x2_4_Result_The_function_is_parallel_x_4()
        {
            //Arrange
            const string expected = "x = 4";

            //Act
            var actual = new LinearFunction(new Coordinates(4, 0, 4, 2)).ToString();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void parallel_OX_Test_same_y1_5_y2_5_Result_The_function_is_parallel_y_5()
        {
            //Arrange
            const string expected = "y = 5";

            //Act
            var actual = new LinearFunction(new Coordinates(8, 5, 22, 5)).ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GreatestCommonDivisor()
        {
            //Act

            var actual = new Fraction(0, 4, 12).GreatestCommonDivisor(4,12).ToString();

            //Assert
            Assert.Equal("4", actual);
        }
        [Fact]
        public void y_is_equal_x()
        {
            //Arrange
            const string expected = "y = x";

            //Act
            var actual = new LinearFunction(new Coordinates(1, 1, 2, 2)).ToString();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
