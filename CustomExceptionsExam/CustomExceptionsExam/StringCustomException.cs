using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsExam
{
    public class StringCustomException :ApplicationException
    {
        public StringCustomException() { }

        public StringCustomException(string message) : base(message) { }
    }
}
