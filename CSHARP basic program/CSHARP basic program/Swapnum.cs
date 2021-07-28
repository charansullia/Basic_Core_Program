using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class Swapnum
    {
        public void Swapoftwonum()
        {
            Console.WriteLine("Enter first number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping first number is" + firstnumber + "second number is" + secondnumber);
            firstnumber = firstnumber + secondnumber;
            secondnumber = firstnumber - secondnumber;
            firstnumber = firstnumber - secondnumber;
            Console.WriteLine("after swapping first number is" + firstnumber + "second number is" + secondnumber);
        }
    }
}