using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class Harmonic
    {
        public void Harmonicnum()
        {
            int i, number;
            double s = 0;
            double S;
            Console.Write("Input the number of terms : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
                Console.Write("Invalid");
            else
            {
                Console.Write("1");
                for (i = 2; i <= number; i++)
                {
                    Console.Write(" + 1/{0}", i);
                    s += 1 / (float)i;
                }
                S = s + 1;
                Console.WriteLine("");
                Console.WriteLine("Sum of Series is : " + S);
            }
        }
    }
}





