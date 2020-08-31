﻿using System;
using System.Runtime.Serialization;

namespace NumberGuessingGame
{
    [Serializable]
    public class DuplicateGuessException : Exception { }

    [Serializable]
    public class GameOverException : Exception
    {
        public GameOverException()
        {
        }

        public GameOverException(string message) : base(message)
        {
        }

        public GameOverException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GameOverException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}