using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a queue
            Queue que = new Queue();
            que.Enqueue("Welcome");
            que.Enqueue("Tutlane");
            que.Enqueue(20.5f);
            que.Enqueue(10);
            que.Enqueue(100);
            Console.WriteLine("***Queue Example***");
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
