using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsExam
{
    public class ExceptionStringBAL
    {
        public void checkString(string str) {
            foreach (char i in str) { 
                if(i== ',' || i=='#' || i== '%' || i == '@')
                {
                    throw new StringCustomException("String Contains Special Characters");
                }
            }
            Console.WriteLine("String is Valid");
        }
    }
}
