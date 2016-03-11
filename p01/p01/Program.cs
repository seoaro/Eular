using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividedByThree = Remainder(1000, 3);
            int dividedByFive = Remainder(1000, 5);
            
            int[] numThree = new int[dividedByThree];
            int[] numFive = new int[dividedByFive];
            int i = 0;
            int j = 0;
            int sum = 0;
            while(i < dividedByThree)
            {
                numThree[i] = (i + 1) * 3;
                sum = sum + numThree[i];
                i++;
            }

            while(j < dividedByFive)
            {
                numFive[j] = (j + 1) * 5;
                sum = sum + numFive[j];
                j++;
            }
            Console.WriteLine("1000 has {0} 3s, {1} 5s and sum of 3s & 5s is {2}", dividedByThree, dividedByFive, sum);
        }

        static int Remainder(int num1, int num2)
        {
            int result;
            int resultTemp;
            resultTemp = num1 % num2;

            if(resultTemp == 0)
            {
                result = num1 / num2 - 1;
            }
            else
            {
                result = num1 / num2;
            }
            return result;
        }
    }
}
