using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopInheritanceExam
{
    public sealed class A { }

    // Here B Can't Inherit class A as A is a sealed class and can't furthur be inherited.
    public class B  :A { }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
