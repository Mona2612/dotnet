using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace sl
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("monika", "senger");
            sl.Add("priyanka", "kumari");
            sl.Add("rohit", "kothari");
            sl.Add("shubham", "rathore");
            sl.Add("tanvi", "singh");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " " + d.Value);

            }
        }
    }
}
