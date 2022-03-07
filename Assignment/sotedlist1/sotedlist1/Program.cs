using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace sotedlist1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("monika", "senger");
            sl.Add("priyanka", "kumari");
            sl.Add("rohit", "kothari");
            sl.Add("tanvi", "singh");
            sl.Add("yahsu", "bansal");
            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " " + d.Value);

            }
        }
    }
}
