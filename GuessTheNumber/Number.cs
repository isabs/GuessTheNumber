using System;
using GuessTheNumber.CompareStrategies;

namespace GuessTheNumber
{
    public class Number
    {
        private CompareStrategy _comparer;

        public int[] Value { get; set; }
        
        public Number(int length, CompareStrategy comparer)
        {
            Value = new int[length];
            _comparer = comparer;
        }

        public void Start()
        {
            GenerateNumber();
        }

        public void GenerateNumber()
        {
            var random = new Random();

            for (var digit = 0; digit < Value.Length; digit++)
            {
                Value[digit] = random.Next(0, 9);
            }
        }

        public string CompareText (int[] number)
        {
            return _comparer.CompareNumbersTextResult(Value, number);
        }

        public bool Compare(int[] number)
        {
            return _comparer.CompareNumbers(Value, number);
        }

        public int GetSumOfDigits()
        {
            var sum = 0;

            Array.ForEach(Value, digit => sum += digit);

            return sum;
        }
    }
}
