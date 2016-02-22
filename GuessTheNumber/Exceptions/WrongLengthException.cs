using System;

namespace GuessTheNumber.Exceptions
{
    public class WrongLengthException : Exception
    {
        public WrongLengthException() : base("Wrong number of digits")
        {
        }
    }
}

