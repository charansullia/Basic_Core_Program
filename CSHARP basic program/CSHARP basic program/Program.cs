using System;

namespace CSHARP_basic_program
{
    class Program
    {
        public void Viewprogram()
        {
            Console.WriteLine("Welcome to Basic core program");
            Console.WriteLine("\n" +
                "1.Flip coin program\n" +
                "2.Leap year program\n" +
                "3.Power of Two\n" +
                "4.Harmonic Program\n" +
                "5.Factor\n" +
                "6.Qoutient and remainder\n" +
                "7.Swapping of two numbers \n" +
                "8.Vowel or consonant\n" +
                "9.Even or odd\n" +
                "10.Greatest of three\n");
            Console.WriteLine("enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Coinflip toss = new Coinflip();
                    toss.headtail();
                    break;
                case 2:
                    Leapyr yr = new Leapyr();
                    yr.leapyear();
                    break;
                case 3:
                    Power2 num = new Power2();
                    num.Poweroftwo();
                    break;
                case 4:
                    Harmonic hnum = new Harmonic();
                    hnum.Harmonicnum();
                    break;
                case 5:
                    Factor primefactor = new Factor();
                    primefactor.factornum();
                    break;
                case 6:
                    QuotientandRemainder RandQ = new QuotientandRemainder();
                    RandQ.QandR();
                    break;
                case 7:
                    Swapnum swap = new Swapnum();
                    swap.Swapoftwonum();
                    break;
                case 8:
                    Alphabetvowels alphabets = new Alphabetvowels();
                    alphabets.vowelconsonant();
                    break;
                case 9:
                    EvenorOdd number = new EvenorOdd();
                    number.Oddoreven();
                    break;
                case 10:
                    Largestnum great = new Largestnum();
                    great.greatestofthree();
                    break;
                default:
                    Console.WriteLine("enter valid key");
                    break;
            }
            Console.WriteLine("\nWants to see another program,IF YES PRESS Y OR ELSE N");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
                Viewprogram();
            else
                Console.WriteLine("OK Bye");


        }
        static void Main(string[] args)
        {
            Program Cprogram = new Program();
            Cprogram.Viewprogram();
        

        }
    }
}
