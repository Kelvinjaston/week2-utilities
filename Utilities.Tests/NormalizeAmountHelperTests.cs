using Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class NormalizeAmountHelperTests
    {
        [Fact]
        public void Normalize_NegativeAmount_ReturnsPositive()
        {
            var result = NormalizeAmountHelper.Normalize(-45.678m);
            Assert.Equal(45.68m, result);
        }

        [Fact]
        public void Normalize_PositiveAmount_ReturnsSameRounded()
        {
            var result = NormalizeAmountHelper.Normalize(100.005m);
            Assert.Equal(100.01m, result);
        }

        [Fact]
        public void Normalize_Zero_ReturnsZero()
        {
            var result = NormalizeAmountHelper.Normalize(0m);
            Assert.Equal(0m, result);
        }

        [Theory]
        [InlineData(10.004, 10.00)]
        [InlineData(10.005, 10.01)]
        [InlineData(-99.999, 100.00)]
        public void Normalize_VariousInputs_ReturnsExpected(double input, double expected)
        {
            var result = NormalizeAmountHelper.Normalize((decimal)input);
            Assert.Equal((decimal)expected, result);
        }
    }
}