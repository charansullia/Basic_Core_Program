using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class EvenorOdd
    {
        public void Oddoreven()
        {
            int number, reminder;
            Console.Write("Input an integer : ");
            number = Convert.ToInt32(Console.ReadLine());
            reminder = number % 2;
            if (reminder == 0)
                Console.WriteLine(number + " is an even integer");
            else
                Console.WriteLine(number + " is an odd integer");
        }
    }
}
    

