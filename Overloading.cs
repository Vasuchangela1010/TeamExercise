using System;

namespace Overloading
{
    class Program
    {
        public static int mulDisplay(int one, int two)
        {
            return one * two;
        }

        public static int mulDisplay(int one, int two, int three)
        {
            return one * two * three;
        }

        public static int mulDisplay(int one, int two, int three, int four)
        {
            return one * two * three * four;
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication of two numbers: " + Program.mulDisplay(8,10));
            Console.WriteLine("Multiplication of three numbers: " + Program.mulDisplay(10,20,30));
            Console.WriteLine("Multiplication of four numbers: " + Program.mulDisplay(5,8,5,12));
        }
    }
}
