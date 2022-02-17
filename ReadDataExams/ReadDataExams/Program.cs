using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ReadDataExams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                FileStream fs2 = new FileStream(@"E:\result.txt", FileMode.Create, FileAccess.Write);
                FileStream fs = new FileStream(@"E:\agent.txt", FileMode.Open, FileAccess.Read);
                StreamReader sm = new StreamReader(fs);
                StreamWriter sm2 = new StreamWriter(fs2);
                string str;
                while ((str=sm.ReadLine()) != null)
                {
                    sm2.WriteLine(str.ToUpper());
                }
                sm2.Flush();
                Console.WriteLine("File Converted Successfully");
            } catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
