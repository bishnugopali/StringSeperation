﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSeperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; /* Declares a string of size 100 */
            int i;
            
            Console.Write("\n\nInput a string :\n");
            Console.Write("---------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            
            char[] array = str.ToCharArray();

            for (i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

       /*   using wjile loop  
          while (l <= str.Length - 1)
            {
                Console.Write("{0} ", str[l]);
                l++;
            }**/


            Console.Write("\n\n");

            

            Console.ReadLine();

        }
    }
}
