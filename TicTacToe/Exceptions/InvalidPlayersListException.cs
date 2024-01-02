using System;
using System.Runtime.Serialization;

namespace TicTacToe.Exceptions
{
    [Serializable]
    internal class InvalidPlayersListException : Exception
    {
        public InvalidPlayersListException():base("Invlaid no of players")
        {
        }

        public InvalidPlayersListException(string message) : base(message)
        {
        }

        public InvalidPlayersListException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPlayersListException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}