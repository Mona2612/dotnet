
            using System;
            using System.Collections;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace linkedtostring
{
    class Program
    {
       
            static void Main(string[] args)
            {
                //create a string 'str1'   
                string str1 = "Welcome     to    Anudip";
                //here StringSplitOptions.RemoveEmptyEntries() is used to remove the spaces between the words.  
                var result = from s in str1.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             select s;
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }