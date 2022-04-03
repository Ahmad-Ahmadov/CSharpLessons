using System;

namespace ThisBaseKeywords
{
    public class Result
    {
        public Result(string message, bool success) : this(success)
        {
            this.Message = message;
            this.Success = success;
        }
        public Result(bool success)
        {
            this.Success = success;
        }

        public string Message { get; set; }
        public bool Success { get; set; }


    }
}
