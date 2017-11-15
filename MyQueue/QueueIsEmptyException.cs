using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FxPro
{
    public class QueueIsEmptyException : Exception
    {
        public QueueIsEmptyException()
        {
        }

        public QueueIsEmptyException(string message) : base(message)
        {
        }

        public QueueIsEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueIsEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
