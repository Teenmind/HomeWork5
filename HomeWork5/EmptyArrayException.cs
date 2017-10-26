using System;
using System.Runtime.Serialization;

namespace HomeWork5
{
    [Serializable]
    public class EmptyArrayException : Exception
    {
        public EmptyArrayException()
        {
        }

        public EmptyArrayException(string message) : base(message)
        {
        }

        public EmptyArrayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyArrayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}