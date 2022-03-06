using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a stack
            Stack stk = new Stack();
            stk.Push("Welcome");
            stk.Push("Tutlane");
            stk.Push(20.5f);
            stk.Push(10);
            stk.Push(null);
            stk.Push(100);
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
