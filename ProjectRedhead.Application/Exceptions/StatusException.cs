using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectRedhead.Application.Exceptions
{
    public class StatusException : Exception
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public StatusException(int code, string title, string message)
        {
            Code = code;
            Title = title;
            Message = message;
        }
    }
}
