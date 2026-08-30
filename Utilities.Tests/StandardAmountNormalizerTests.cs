using Utilities;
using Xunit;

namespace Utilities.Tests
{
    public class StandardAmountNormalizerTests
    {
        [Fact]
        public void Normalize_NegativeAmount_ReturnsPositive()
        {
            var normalizer = new StandardAmountNormalizer();
            var result = normalizer.Normalize(-45.678m);
            Assert.Equal(45.68m, result);
        }
        [Fact]
        public void Normalize_PositiveAmount_ReturnsSameRounded()
        {
            var normalizer = new StandardAmountNormalizer();
            var result = normalizer.Normalize(100.005m);
            Assert.Equal(100.01m, result);
        }
        [Fact]
        public void Normalize_Zero_ReturnsZero()
        {
            var normalizer = new StandardAmountNormalizer();
            var result = normalizer.Normalize(0m);
            Assert.Equal(0m, result);
        }
        [Fact]
        public void Normalize_CanBeCalledThroughInterface()
        {
            IAmountNormalizer normalizer = new StandardAmountNormalizer();
            var result = normalizer.Normalize(-99.999m);
            Assert.Equal(100.00m, result);
        }
    }
}