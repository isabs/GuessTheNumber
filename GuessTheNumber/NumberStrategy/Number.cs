using System;

namespace GuessTheNumber.NumberStrategy
{
    public abstract class Number
    {
        public int[] Value { get; set; }

        protected Number(int length)
        {
            GenerateNumber(length);
        }

        public void GenerateNumber(int length)
        {
            var random = new Random();

            Value = new int[length];

            for (var digit = 0; digit < length; digit++)
            {
                Value[digit] = random.Next(0, 9);
            }
        }
    }
}
