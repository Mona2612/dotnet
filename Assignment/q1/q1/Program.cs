using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue("monika");
            que.Enqueue("senger");
            que.Enqueue(26);
            que.Enqueue(12);
            que.Enqueue(2000);
            Console.WriteLine("Number of Elements in Queue: {0}", que.Count);
            Console.WriteLine("***Queue Elements***");
            // Access Queue Elements
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
