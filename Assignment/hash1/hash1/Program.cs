using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace hash1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "monika");
            hash.Add(2, "senger");
            hash.Add(3, "faridabad");
            hash.Add(4, "haryana");
            hash.Add(5, "student");
            hash.Add(6, "dotnet");
            hash.Add(7, "c++");
            hash.Add(8, "c#");
            hash.Add(9, "visual basic");
            hash.Add(10, "datastructure");
            foreach(DictionaryEntry a in hash)
                Console.WriteLine("key:{0},value:{1}",a.Key,a.Value);
        }
    }
}
