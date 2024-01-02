using System;
using System.Runtime.Serialization;

namespace TicTacToe.Exceptions
{
    [Serializable]
    internal class InvalidSymbolException : Exception
    {
        public InvalidSymbolException(): base("You have entered an invalid symbol. Symbol should be unique for each player")
        {
        }

        public InvalidSymbolException(string message) : base(message)
        {
        }

        public InvalidSymbolException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidSymbolException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}