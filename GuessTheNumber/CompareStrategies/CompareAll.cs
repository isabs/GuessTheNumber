using GuessTheNumber.Exceptions;

namespace GuessTheNumber.CompareStrategies
{
    public class CompareAll : CompareStrategy
    {
        public override string CompareNumbers(int[] correctNumber, int[] number)
        {
            if (correctNumber.Length != number.Length) throw new WrongLengthException();

            var fullCorrectNumber = 0;
            var fullNumber = 0;

            for (var digit = 0; digit < correctNumber.Length; digit++)
            {
                fullCorrectNumber = fullCorrectNumber*10 + correctNumber[digit];
                fullNumber = fullNumber*10 + number[digit];
            }

            return CompareText(Compare(fullCorrectNumber, fullNumber), fullNumber);
        }
    }
}

