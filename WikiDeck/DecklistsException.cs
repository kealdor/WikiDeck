using System;
using System.Runtime.Serialization;

namespace WikiDeck
{
    [Serializable]
    internal class DecklistsException : Exception
    {
        public DecklistsException()
        {
        }

        public DecklistsException(string message) : base(message)
        {
        }

        public DecklistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DecklistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}