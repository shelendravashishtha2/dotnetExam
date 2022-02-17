using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;

namespace NameValueCollectionExam
{
    // This is the collection contains string keys and string values. Values can be accessed using
    // Keys and Indexes. This collection is defined under System.Collections.Specialized namespace
    public class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection coll = new NameValueCollection();

            // Adding the values
            coll.Add("Key1", "Value1");

            // Get All Keys
            foreach(string s in coll.AllKeys)
            {
                Console.WriteLine(s + " : " + coll[s]);
            }

            // Get the keys and values
            for(int i =0;i<coll.Count;i++)
            {
                Console.WriteLine(coll.GetKey(i) + " : " + coll.Get(i));
            }
        }
    }
}
