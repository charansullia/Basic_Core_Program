using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class Power2
    {
        public void Poweroftwo()
        {
            Console.WriteLine("Enter the maximum power you want");
            double maxpow = Convert.ToInt32(Console.ReadLine());
            double power;
            for (int i = 1; i <= maxpow; i++)
            {
                power = Math.Pow(2, i);
                Console.WriteLine("power of 2^" + i + "  is: " + power);
                Console.WriteLine("............................................");
            }

        }
    }
}