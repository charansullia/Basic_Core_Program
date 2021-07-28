using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_program
{
    class Coinflip
    {
        public void headtail()
        {
            int count = 0;
            double headcount = 0;
            double tailcount = 0;
            double headpercentage;
            double tailpercentage;
            Console.WriteLine("enter number of flips you want");
            double numofflips = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            while (count < numofflips)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    Console.WriteLine("its tail");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("its head");
                    headcount++;
                }
                count++;
                Console.WriteLine("..............................");
            }
            Console.WriteLine("number of head count =" + headcount);
            Console.WriteLine("number of tail count =" + tailcount);
            headpercentage = (headcount / numofflips) * 100;
            tailpercentage = (tailcount / numofflips) * 100;
            Console.WriteLine("head percentage is" + headpercentage + "%");
            Console.WriteLine("tail percentage is" + tailpercentage + "%");

        }
    }
}