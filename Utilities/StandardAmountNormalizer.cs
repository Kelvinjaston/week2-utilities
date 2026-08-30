using System;

namespace Utilities
{
    public class StandardAmountNormalizer : IAmountNormalizer
    {
        public decimal Normalize(decimal amount)
        {
            return Math.Abs(Math.Round(amount, 2, MidpointRounding.AwayFromZero));
        }
    }
}
