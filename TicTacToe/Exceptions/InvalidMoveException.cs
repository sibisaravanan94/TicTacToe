using System;
using System.Runtime.Serialization;

namespace TicTacToe.Exceptions
{
    [Serializable]
    internal class InvalidMoveException : Exception
    {
        private int x;
        private int y;

        public InvalidMoveException()
        {
        }

        public InvalidMoveException(string message) : base(message)
        {
        }

        public InvalidMoveException(int x, int y) : this("The move was invalid: " + x + " " + y)
        {
            this.x = x;
            this.y = y;
        }

        public InvalidMoveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidMoveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}