namespace Utilities
{
    public static class NormalizeAmountHelper 
    {
        public static decimal Normalize(decimal amount)
        {
            return Math.Abs(Math.Round(amount, 2, MidpointRounding.AwayFromZero));
        }

    }
}
