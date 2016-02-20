using System;

namespace GuessTheNumber.Exceptions
{
    class WrongLengthException : Exception
    {
        public WrongLengthException() : base("Wrong number of digits")
        {
        }
    }
}

