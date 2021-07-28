using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class QuotientandRemainder
    {
        public void QandR()
        {
            Console.WriteLine("Enter the dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int qoutient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Qoutient is :" + qoutient);
            Console.WriteLine("Remainder is :" + remainder);
        }
    }
}
    

