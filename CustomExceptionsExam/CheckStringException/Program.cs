using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomExceptionsExam;

namespace CheckStringException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            try {
                new ExceptionStringBAL().checkString(str);
            }catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
