using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class Largestnum
    {
        public void greatestofthree()
        {
            Console.WriteLine("Enter first number");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdnumber = Convert.ToInt32(Console.ReadLine());
            if ((firstnumber > secondnumber) && (firstnumber > thirdnumber))
                Console.WriteLine("Greatest of three is " + firstnumber);
            if ((secondnumber > firstnumber) && (secondnumber > thirdnumber))
                Console.WriteLine("Greatest of three is " + secondnumber);
            if ((thirdnumber > firstnumber) && (thirdnumber > secondnumber))
                Console.WriteLine("Greatest of three is " + thirdnumber);

        }
    }
}