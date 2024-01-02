using System;
using System.Runtime.Serialization;

namespace TicTacToe.Models
{
    [Serializable]
    internal class InvalidBoardCellException : Exception
    {
        public InvalidBoardCellException(): base("Invalid board cell input")
        {
        }

        public InvalidBoardCellException(string message) : base(message)
        {
        }

        public InvalidBoardCellException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidBoardCellException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}