using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSNFormat
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] ssnNumber = Console.ReadLine().Split('-');
            if(ssnNumber.Length == 3)
            {
                try {
                    Convert.ToInt32(ssnNumber[0]);
                    Convert.ToInt32(ssnNumber[1]);
                    Convert.ToInt32(ssnNumber[2]);
                    if (ssnNumber[0].Length == 3  && ssnNumber[1].Length==2 && ssnNumber[2].Length == 4)
                    {
                        Console.WriteLine("SSN Number is correct");
                    }
                    else
                    {
                        Console.WriteLine("SSN number is incorrect");
                    }

                }catch {
                    Console.WriteLine("SSN number is incorrect");
                }
            }
            else
            {
                Console.WriteLine("SSN number is incorrect");
            }


        }
    }
}
