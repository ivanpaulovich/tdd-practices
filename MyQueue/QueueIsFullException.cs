using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FxPro
{
    public class QueueIsFullException : Exception
    {
        public QueueIsFullException()
        {
        }

        public QueueIsFullException(string message) : base(message)
        {
        }

        public QueueIsFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueIsFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
