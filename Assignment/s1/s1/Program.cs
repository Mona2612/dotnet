using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace s1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push("delhi");
            stk.Push("faridabad");
            stk.Push(2000);
            stk.Push(199.23f);
            stk.Push(null);
            stk.Push("india");
            Console.WriteLine("Number of Elements in Stack: {0}", stk.Count);
            Console.WriteLine("***Stack Elements***");
            // Access Stack Elements
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
