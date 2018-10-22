using System;

namespace LaptimeLeaderboard.Library.Exceptions
{
    public class HttpException : Exception
    {
        public HttpException() : base("A general error has occured.")
        {
            StatusCode = 500;
        }
        public HttpException(string Message) : base(Message)
        {
            StatusCode = 500;
        }
        public HttpException(int StatusCode, string Message) : base(Message)
        {
            this.StatusCode = StatusCode;
        }

        public int StatusCode { get; set; }
    }
}
