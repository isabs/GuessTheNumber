using System;
using GuessTheNumber.Enums;
using GuessTheNumber.Exceptions;

namespace GuessTheNumber.CompareStrategies
{
    class CompareDigits : CompareStrategy
    {
        public override string CompareNumbers(int[] correctNumber, int[] number)
        {
            if(correctNumber.Length != number.Length) throw new WrongLengthException();

            var results = string.Empty;

            for (var digit = 0; digit < correctNumber.Length; digit++)
            {
                results += (CompareText(Compare(correctNumber[digit], number[digit]), number[digit]) + "\n");
            }

            return results;
        }
    }
}
