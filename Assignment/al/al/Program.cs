﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace al
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList al = new ArrayList();
         
         Console.WriteLine("Adding some numbers:");
         al.Add(11);
         al.Add(29);
         al.Add(11);
         al.Add(100);
     
         Console.WriteLine("Capacity: {0} ", al.Capacity);
         Console.WriteLine("Count: {0}", al.Count);
         
         Console.Write("Content: ");
         foreach (int i in al) {
            Console.Write(i + " ");
         }
         
         Console.WriteLine();
         Console.Write("Sorted Content: ");
         al.Sort();
         foreach (int i in al) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
        }
    }
