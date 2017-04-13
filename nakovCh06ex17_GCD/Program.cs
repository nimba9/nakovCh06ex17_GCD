using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCh06ex17_GCD
{
    class EuclidAlgo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 positive integers: ");
            string numA = Console.ReadLine();
            string numB = Console.ReadLine();

            int a = 0;
            int b = 0;

            bool checkA = int.TryParse(numA, out a);
            bool checkB = int.TryParse(numB, out b);

            if (checkA != true || checkB != true)
            {
                Console.WriteLine("Please enter a positive integer");
            }


            Console.WriteLine("The greatest common divisor for {0} and {1} is:{2} ",a, b, GCD(a, b));
            Console.WriteLine("The least common multiple   for {0} and {1} is:{2} ", a, b, LCM(a, b));
        }

        

        public static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b; 
            }

            while (b != 0)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

                return a;

        }

        public static int LCM(int a, int b)
        {
            int result = (a * b) / GCD(a, b);
            return result; 
        }
    }
}
