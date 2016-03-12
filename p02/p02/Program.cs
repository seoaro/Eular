using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int one = 1;
            int two = 2;
            int three = 3;

            int fiboNum = 0;
            int sum = 0;
            while(fiboNum <= 4000000)
            {
                three = one + two;
                one = two;
                two = three;
                fiboNum = two - one;
                i++;
                if(fiboNum%2 == 0)
                {
                    sum = sum + fiboNum;
                }
                Console.WriteLine("i = {0} : {1}, {2}, {3}", i, fiboNum, one, two);

            }
            Console.WriteLine("sum = " + sum);

        }
    }
}
