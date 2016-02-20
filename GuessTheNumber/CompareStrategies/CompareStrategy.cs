using GuessTheNumber.Enums;
using GuessTheNumber.Exceptions;

namespace GuessTheNumber.CompareStrategies
{
    public abstract class CompareStrategy
    {
        public abstract string CompareNumbers(int[] correctNumber, int[] number);

        protected CompareResult Compare(int correctDigit, int otherDigit)
        {
            return otherDigit > correctDigit
                ? CompareResult.Above
                : (otherDigit < correctDigit 
                    ? CompareResult.Below 
                    : CompareResult.Equal);
        }

        protected string CompareText(CompareResult result, int digit)
        {
            switch (result)
            {
                case CompareResult.Below:
                    return $"Number {digit} is too low";
                case CompareResult.Equal:
                    return $"Number {digit} OK";
                case CompareResult.Above:
                    return $"Number {digit} is too great";
                default:
                    throw new UnhandledResultType();
            }
        }
    }
}
