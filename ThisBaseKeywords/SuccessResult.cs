﻿using System;

namespace ThisBaseKeywords
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(message,true)
        {
        }
        public SuccessResult() : base(true)
        {

        }
    }
}
