using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Selector
    {
        private int num;
        public int Number
        {
            set
            {
                num = value;
            }
            get
            {
                return num;
            }
        }
        public Selector ()
        {

        }
        public Selector (int arg)
        {
            Console.WriteLine("#{0} problem is Running...", arg);
            switch(arg)
            {
                case 1:
                    Problem1();
                    break;

                case 2:
                    Problem2();
                    break;

                case 3:
                    Problem3();
                    break;

                case 4:
                    Problem4();
                    break;

                case 5:
                    Problem5();
                    break;

                case 6:
                    Problem6();
                    break;

                case 8:
                    Problem8();
                    break;

                default:
                    Console.WriteLine("There is no #{0} problem.", arg);
                    break;
                
            }
        
        }

        // Problem1
        static void Problem1()
        {
            int dividedByThree = Remainder(1000, 3);
            int dividedByFive = Remainder(1000, 5);

            int[] numThree = new int[dividedByThree];
            int[] numFive = new int[dividedByFive];
            int i = 0;
            int j = 0;
            int sum = 0;
            while (i < dividedByThree)
            {
                numThree[i] = (i + 1) * 3;
                sum = sum + numThree[i];
                i++;
            }

            while (j < dividedByFive)
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

            if (resultTemp == 0)
            {
                result = num1 / num2 - 1;
            }
            else
            {
                result = num1 / num2;
            }
            return result;
        }

        // Problem2
        static void Problem2()
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

        // Problem3
        static void Problem3()
        {
            int i = 0;
            Int64 j = 600851475143;

            while (true)
            {
                i++;
                if (j % i == 0)
                {
                    j = j / i;
                    Console.WriteLine("j = {0}, i = {1}", j, i);
                }
                else if (j == 1)
                {
                    break;
                }


            }
        }

        //Problem4
        static void Problem4()
        {
            int result;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    result = i * j;
                    if (result > 900000 && result < 1000000)
                    {
                        string str = result.ToString();
                        char[] chr = str.ToCharArray();
                        if (chr[0].Equals(chr[5]) && chr[1].Equals(chr[4]) && chr[2].Equals(chr[3]))
                        {
                            Console.WriteLine("{0} X {1} = {2}{3}{4}{5}{6}{7}", i, j, chr[0], chr[1], chr[2], chr[3], chr[4], chr[5]);
                        }
                    }

                }
            }
        }

        //Problem5
        static void Problem5()
        {
            int i = 0;
            Int64 num = 1;
            int compare = 0;
            while (true)
            {
                while (i < 10)
                {
                    if (num % (i + 1) == 0)
                    {
                        compare++;
                    }
                    i++;
                }
                if (compare == 10)
                {
                    Console.WriteLine("The Number is : {0}", num);
                    break;
                }
                num++;
                i = 0;
                compare = 0;


            }
        }

        // Problem6

        static void Problem6()
        {
            double sum1 = 0;
            double sum2 = 0;

            for (double i = 0; i < 100;i++)
            {
                sum1 = sum1 + Math.Pow(i + 1, 2);
                sum2 = sum2 + (i + 1);
            }
            sum2 = Math.Pow(sum2, 2);
            double result = sum2 - sum1;
            Console.WriteLine("{0} - {1} = {2}",sum2, sum1, result);

        }


        // Problem8
        static void Problem8()
        {
            int a;
            int b;
            int c;
            
            for (int i = 0; i < 1000; i++)
            {
                a = i + 1;
                for(int j = 0; j < 1000; j++)
                {
                    b = j + 1;
                    for(int k = 0; k < 1000; k++)
                    {
                        c = k + 1;
                        if(a < b && b < c && a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                        {
                            Console.WriteLine("a: {0} b: {1} c: {2} and a x b x c = {3}", a, b, c, a * b * c);
                            break;
                        }
                    }
                }
            }
        }














    }
}
