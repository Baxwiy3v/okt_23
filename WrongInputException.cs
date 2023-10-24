﻿using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class WrongInputException : Exception
    {
        public WrongInputException()
        {
        }

        public WrongInputException(string message) : base(message)
        {
        }

        public WrongInputException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}