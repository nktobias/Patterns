namespace DiceRoller
{
    public class ThrowResult
    {
        public ThrowResult(ThrowResultType type, int successCount)
        {
            Type = type;
            SuccessCount = successCount;
        }

        public ThrowResultType Type { get; private set; }
        public int SuccessCount { get; private set; }
    }
}
