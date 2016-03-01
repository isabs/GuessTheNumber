using System.Linq;
using GuessTheNumber.Enums;
using GuessTheNumber.Exceptions;

namespace GuessTheNumber.CompareStrategies
{
    public abstract class CompareStrategy
    {
        public string Name { get; set; }

        protected CompareStrategy(string name)
        {
            Name = name;
        }

        public abstract string CompareNumbersTextResult(int[] correctNumber, int[] number);

        public bool CompareNumbers(int[] correctNumber, int[] number)
        {
            if (correctNumber.Length != number.Length) throw new WrongLengthException();

            return !correctNumber.Where((t, digit) => Compare(t, number[digit]) != CompareResult.Equal).Any();
        }

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
