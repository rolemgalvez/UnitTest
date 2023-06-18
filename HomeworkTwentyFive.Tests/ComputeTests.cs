using HomeworkTwentyFive.Library;
using Xunit;

namespace HomeworkTwentyFive.Tests
{
    public class ComputeTests
    {
        [Fact]
        public void TakeHomePayShouldReturn8000()
        {
            // Arrange
            double expected = 8000;

            // Act
            double actual = Compute.TakeHomePay(1000, 10, 20);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 1, 10, 90)]
        [InlineData(200, 2, 20, 320)]
        [InlineData(300, 3, 30, 630)]
        public void TakeHomePayShouldReturnCorrectOutput(
            double basicSalary,
            int daysOfWork,
            double taxPercentage,
            double expected)
        {
            // Arrange

            // Act
            double actual = Compute.TakeHomePay(basicSalary, daysOfWork, taxPercentage);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
