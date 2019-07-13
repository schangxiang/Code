using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB_CustomerException
{
    class MyException : ApplicationException
    {
        public string error;
        private Exception innerException;

        public MyException() { }
        public MyException(string msg) :base(msg)
        {
            this.error = msg;
        }
        public MyException(string msg, Exception innerException):base(msg,innerException)
        {
            this.innerException = innerException;
            error = msg;
        }
        public string GetError()
        {
            return error;
        }
    }
}
