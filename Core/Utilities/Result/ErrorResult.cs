﻿namespace Core.Utilities.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(string massage) : base(false, massage)
        {


        }

        public ErrorResult() : base(false)
        {

        }
    }
}
