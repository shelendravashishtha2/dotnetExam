using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeZones
{
    class Time1
    {
        int hours { get; set; }
        int mins { get; set; }

        public Time1(int hours, int mins) { this.hours = hours; this.mins = mins; }

        public static Time1 convertTimes(Time1 t1,Time1 t2)
        {
            if(t1==null || t2==null)
            {
                Console.WriteLine("Times are not correct");
                return null;
            }
            DateTime d1 = DateTime.Parse(t1.hours + " : " + t1.mins);
            DateTime d2 = DateTime.Parse(t2.hours + " : " + t2.mins);
            DateTime d3 = d1.Add(d2.TimeOfDay);
            return new Time1(d3.Hour, d3.Minute);
        } 
        public override string ToString()
        {
            return hours + " hr " + mins + "mins";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Time\n Hours : ");
            int hour1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mins : ");
            int min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Time\n Hours : ");
            int hour2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mins : ");
            int min2 = Convert.ToInt32(Console.ReadLine());
            Time1 result = Time1.convertTimes(new Time1(hour1, min1), new Time1(hour2, min2));

            Console.WriteLine(result);
        }
    }
}
