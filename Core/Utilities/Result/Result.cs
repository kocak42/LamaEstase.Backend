﻿namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool succes)
        {
            Success = succes;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
