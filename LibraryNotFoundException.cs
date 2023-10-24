using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class LibraryNotFoundException : Exception
    {
        public LibraryNotFoundException()
        {
        }

        public LibraryNotFoundException(string message) : base(message)
        {
        }

        public LibraryNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LibraryNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}