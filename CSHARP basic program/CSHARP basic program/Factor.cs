using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class Factor
    {
        public void factornum()
        {
            Console.WriteLine("Enter the number to get factor");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                    number /= i;
                }
            }
        }
    }
}


    

