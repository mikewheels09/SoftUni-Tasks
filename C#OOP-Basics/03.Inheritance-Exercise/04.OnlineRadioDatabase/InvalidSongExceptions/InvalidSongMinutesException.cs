﻿namespace _04.OnlineRadioDatabase.InvalidSongExceptions
{
    namespace _04.OnlineRadioDatabase.Exceptions
    {
        public class InvalidSongMinutesException : InvalidSongLengthException
        {
            private const string Message = "Song minutes should be between 0 and 14.";

            public InvalidSongMinutesException() : base(Message)
            {
            }

            public InvalidSongMinutesException(string message) : base(message)
            {
            }
        }
    }
}
