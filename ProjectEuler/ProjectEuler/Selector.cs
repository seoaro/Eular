using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

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
        public Selector()
        {
            //
        }
        public Selector(int arg)
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

                case 7:
                    Problem7();
                    break;

                case 8:
                    Problem8();
                    break;

                case 9:
                    Problem9();
                    break;

                case 10:
                    Problem10();
                    break;

                case 11:
                    Problem11();
                    break;

                case 12:
                    Problem12();
                    break;

                case 13:
                    Problem13();
                    break;

                case 14:
                    Problem14();
                    break;

                case 16:
                    Problem16();
                    break;

                case 18:
                    Problem18();
                    break;

                case 20:
                    Problem20();
                    break;

                case 21:
                    Problem21();
                    break;

                case 22:
                    Problem22();
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
            int dividedByFifteen = Remainder(1000, 15);

            int[] numThree = new int[dividedByThree];
            int[] numFive = new int[dividedByFive];
            int[] numFifteen = new int[dividedByFifteen];
            int i = 0;
            int j = 0;
            int k = 0;
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
            
            while (k < dividedByFifteen)
            {
                numFifteen[k] = (k + 1) * 15;
                sum = sum - numFifteen[k];
                k++;
            }
            Console.WriteLine("1000 has {0} 3s, {1} 5s , {2} 15s and sum of 3s & 5s is {3}", dividedByThree, dividedByFive, dividedByFifteen, sum);
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
                while (i < 20)
                {
                    if (num % (i + 1) == 0)
                    {
                        compare++;
                    }
                    i++;
                }
                if (compare == 20)
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
        // Problem7
        static void Problem7()
        {
            ArrayList primeNumbers = new ArrayList();
            int num = 0;
            bool flag = true;
            for (int i = 2; i <= 190000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    primeNumbers.Add(i);
                    num++;
                    if(num == 10001)
                    {
                        Console.WriteLine("P# is {0}", i);
                        break;
                    }
                    
                }
                flag = true;
            }
            
            
        }
        // Problem8
        static void Problem8()
        {
            ReadFromFile NumberText = new ReadFromFile("Numbers");

            int multiNum = 0;
            int compare = 0;
            for(int i = 0; i < 995; i++)
            {
                string m = NumberText.NumberString[i].ToString();
                string n = NumberText.NumberString[i + 1].ToString();
                string o = NumberText.NumberString[i + 2].ToString();
                string p = NumberText.NumberString[i + 3].ToString();
                string q = NumberText.NumberString[i + 4].ToString();
                int a, b, c, d, e; 
                Int32.TryParse(m, out a);
                Int32.TryParse(n, out b);
                Int32.TryParse(o, out c);
                Int32.TryParse(p, out d);
                Int32.TryParse(q, out e);
               
                multiNum = a * b * c * d * e;
                Console.WriteLine("{0} : {1}X{2}X{3}X{4}X{5} = {6}", i, a, b, c, d, e, multiNum);
                if(multiNum > compare)
                {
                    compare = multiNum;
                }
            }
            Console.WriteLine("Biggest Num is {0}", compare);
        }

        // Problem9
        static void Problem9()
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

        // Problem10
        static void Problem10()
        {
            ArrayList primeNumbers = new ArrayList();
            int sum = 0;
            bool flag = true;
            for(int i = 2; i <= 2000000; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    primeNumbers.Add(i);
                    Console.WriteLine("P# is {0}", i);
                }
                flag = true;
            }
            foreach (object obj in primeNumbers)
            {
                sum = sum + Convert.ToInt32(obj);
            }
            Console.WriteLine("The sum is {0}", sum);
        }

        // Problem11
        static void Problem11()
        {
            ReadFromFile TwentyText = new ReadFromFile("20X20");

            string[] lStr = TwentyText.LineString;
            List<int> numList = new List<int>();

            int i = 0;
            
            foreach(string stringElement in lStr)
            {

                for (int j = 0; j < stringElement.Length - 1; j = j + 3)
                {

                    string str = stringElement[j].ToString() + stringElement[j + 1].ToString();
                    int result;
                    Int32.TryParse(str, out result);
                    numList.Add(result);
                    
                }
                i = i + 2;
            }
            
            int lDiagonal = 0;
            int rDiagonal = 0;
            int vertical = 0;
            int horizontal = 0;

            for (int l = 0; l <= 320; l = l + 20)
            {
                for (int k = 0; k < 17; k++)
                {
                    int multiplLdia = numList[k + l] * numList[k + l + 21] * numList[k + l + 42] * numList[k + l + 63];
                    int multiplRdia = numList[k + l + 3] * numList[k + l + 22] * numList[k + l + 41] * numList[k + l + 60];
                    int multiHor = numList[k + l] * numList[k + l + 1] * numList[k + l + 2] * numList[k + l + 3];

                    if(multiplLdia > lDiagonal)
                    {
                        lDiagonal = multiplLdia;
                    }
                    if(multiplRdia > rDiagonal)
                    {
                        rDiagonal = multiplRdia;
                    }
                    if(multiHor > horizontal)
                    {
                        horizontal = multiHor;
                    }
                    //Console.WriteLine("{0} X {1} X {2} X {3} = {4}", numList[k + l], numList[k + l + 21], numList[k + l  + 42], numList[k + l + 63], multiplLdia);
                    Console.WriteLine("{0} X {1} X {2} X {3} = {4}", numList[k + l + 3], numList[k + l + 22], numList[k + l + 41], numList[k + l + 60], multiplRdia);
                }

                for (int m = 0; m < 20; m++)
                {
                    int multiplVert = numList[m + l] * numList[m + l + 20] * numList[m + l + 40] * numList[m + l + 60];

                    if(multiplVert > vertical)
                    {
                        vertical = multiplVert;
                    }

                }

            }
            
            Console.WriteLine("lDiagonal is : {0}", lDiagonal);
            Console.WriteLine("rDiagonal is : {0}", rDiagonal);
            Console.WriteLine("Horizontal is : {0}", horizontal);
            Console.WriteLine("Vertical is : {0}", vertical);
        }

        // Problem12
        static void Problem12()
        {
            int num = 0;
            int i = 1;
            int size = 0;

            while(true)
            {
                size = 0;
                num = num + i;
                List<int> yaksu = new List<int>();
                for(int j = 1; j <= num; j++)
                {
                    if(num % j == 0)
                    {
                        yaksu.Add(j);
                    }
                }
                string str = "";
                foreach(int ele in yaksu)
                {
                    str = str + " " + ele.ToString();
                    size++;
                }
                
                Console.WriteLine("{0}: {1} size{2}", num, str, size);
                i++;
                if(size >= 500)
                {
                    break;
                }
            }
        }

        // Problem13
        static void Problem13()
        {
            ReadFromFile FiftyNum = new ReadFromFile("50X100");
            string[] strArray = FiftyNum.LineString;
            
            int i = 0;

            Int64 sum1to10 = 0;
            Int64 sum11to20 = 0;
            Int64 sum21to30 = 0;
            Int64 sum31to40 = 0;
            Int64 sum41to50 = 0;
            
            foreach(string element in FiftyNum.LineString)
            {
                string strTemp1to10 = "";
                string strTemp11to20 = "";
                string strTemp21to30 = "";
                string strTemp31to40 = "";
                string strTemp41to50 = "";
                for(int j = 0; j < 10; j++)
                {
                    strTemp1to10 = strTemp1to10 + element[j].ToString();
                    strTemp11to20 = strTemp11to20 + element[j + 10].ToString();
                    strTemp21to30 = strTemp21to30 + element[j + 20].ToString();
                    strTemp31to40 = strTemp31to40 + element[j + 30].ToString();
                    strTemp41to50 = strTemp41to50 + element[j + 40].ToString();
                    
                }

                Int64 intTemp1to10;
                Int64 intTemp11to20;
                Int64 intTemp21to30;
                Int64 intTemp31to40;
                Int64 intTemp41to50;
                Int64.TryParse(strTemp1to10, out intTemp1to10);
                Int64.TryParse(strTemp11to20, out intTemp11to20);
                Int64.TryParse(strTemp21to30, out intTemp21to30);
                Int64.TryParse(strTemp31to40, out intTemp31to40);
                Int64.TryParse(strTemp41to50, out intTemp41to50);
                
                sum1to10 = sum1to10 + intTemp1to10;
                sum11to20 = sum11to20 + intTemp11to20;
                sum21to30 = sum21to30 + intTemp21to30;
                sum31to40 = sum31to40 + intTemp31to40;
                sum41to50 = sum41to50 + intTemp41to50;
                //Console.WriteLine("#{0} str : {1} | num : {2} | sum : {3}", i, strTemp41to50, intTemp41to50, sum41to50);
                i++;
                if (i == 100)
                {
                    string strTemp3940 = sum41to50.ToString();
                    strTemp3940 = strTemp3940[0].ToString() + strTemp3940[1].ToString();
                    Int64 intTemp3940;
                    Int64.TryParse(strTemp3940, out intTemp3940);

                    sum31to40 = sum31to40 + intTemp3940;
                    string strTemp2930 = sum31to40.ToString();
                    strTemp2930 = strTemp2930[0].ToString() + strTemp2930[1].ToString();
                    Int64 intTemp2930;
                    Int64.TryParse(strTemp2930, out intTemp2930);

                    sum21to30 = sum21to30 + intTemp2930;
                    string strTemp1920 = sum21to30.ToString();
                    strTemp1920 = strTemp1920[0].ToString() + strTemp1920[1].ToString();
                    Int64 intTemp1920;
                    Int64.TryParse(strTemp1920, out intTemp1920);

                    sum11to20 = sum11to20 + intTemp1920;
                    string strTemp910 = sum11to20.ToString();
                    strTemp910 = strTemp910[0].ToString() + strTemp910[1].ToString();
                    Int64 intTemp910;
                    Int64.TryParse(strTemp910, out intTemp910);

                    sum1to10 = sum1to10 + intTemp910;

                    string digits = sum1to10.ToString();
                    string firstTenDigits = "";
                    for(int k = 0; k < 10; k++)
                    {
                        firstTenDigits = firstTenDigits + digits[k].ToString();
                    }

                        Console.WriteLine("The first 10 digits are {0}", firstTenDigits);
                }
            }
        }

        // Problem14
        static void Problem14()
        {
            Int64 num;
            Int64 countMax = 0;
            
            for(Int64 i = 2; i <= 1000000; i++)
            {
                num = i;
                Int64 count = 0;
                while(num != 1)
                {
                    if(num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = num * 3 + 1;
                    }
                    count++;
                    if(num == 1 && count > countMax)
                    {
                        countMax = count;
                        Console.WriteLine("The number is {0} and count is {1}", i, countMax);
                    }
                }
            }
        }

        // Problem16
        static void Problem16()
        {
            double number = Math.Pow(2, 1000);
            BigInteger num = (BigInteger)number;
            string powofTwo = num.ToString();
            int sum = 0;
            foreach(char element in powofTwo)
            {
                string strTemp = element.ToString();
                int intTemp;
                Int32.TryParse(strTemp, out intTemp);
                sum = sum + intTemp;
            }
            Console.WriteLine("{0}", sum);
        }

        // Problem18
        static void Problem18()
        {
            ReadFromFile triangle1 = new ReadFromFile("triangle1");
            string[] strArray = triangle1.LineString;
            int j = 0;
            int sum = 0;
            foreach(string element in strArray)
            {
                int i = 0;
                List<int> intList = new List<int>();
                while(i < j + 1)
                {
                    string numStr = "";
                    numStr = numStr + element[i].ToString() + element[i + 1].ToString();
                    int intTemp;
                    Int32.TryParse(numStr, out intTemp);
                    //Console.WriteLine("##{0}: {1} ", j, intTemp);
                    intList.Add(intTemp);
                    i = i + 3;
                }
                int compare = 0;
                foreach(int eleInt in intList)
                {
                    if(eleInt > compare)
                    {
                        compare = eleInt;
                    }
                }
                Console.WriteLine("#{0}: {1}", j, compare);
                j = j + 3;
                sum = sum + compare;
            }
            Console.WriteLine("The sum of max numbers of each line is {0}", sum);
        }

        // Problem20
        static void Problem20()
        {
            BigInteger result = 1;
            for(int n = 100; n > 0; n--)
            {
                result = result * n;
                Console.WriteLine("#{0}: {1}", n, result);
            }
            Console.WriteLine("##{0}", result);
            string strNum = result.ToString();

            int sum = 0;
            foreach(char element in strNum)
            {
                string strTemp = element.ToString();
                int intTemp;
                Int32.TryParse(strTemp, out intTemp);
                sum = sum + intTemp;
            }
            Console.WriteLine("The sum of result is {0}", sum);
        }

        // Problem21
        static void Problem21()
        {
            int a = 10000;
            int sumAll = 0;

            while (a > 0)
            {
                int sumA = 0;
                for (int i = 1; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        sumA = sumA + i;
                    }
                }
                //Console.WriteLine("d(a): {0}", sumA);

                int b = sumA;
                int sumB = 0;
                for (int j = 1; j < b; j++)
                {
                    if (b % j == 0)
                    {
                        sumB = sumB + j;
                    }
                }
                //Console.WriteLine("d(b): {0}", sumB);
                if (sumB == a && a != b)
                {
                    Console.WriteLine("d({0}) = {1} & d({2}) = {3}", sumB, b, sumA, a);
                    sumAll = sumAll + a;
                }
                a--;
            }
            Console.WriteLine("sum : {0}", sumAll);

        }

        // Problem22
        static void Problem22()
        {
            ReadFromFile Names = new ReadFromFile("names");
            string allStr = Names.NumberString;
            string[] splitStr = allStr.Split(',');
            List<string> strList = new List<string>();
            foreach(string element in splitStr)
            {
                string strTemp = element.Replace('"', ' ');
                strTemp = strTemp.Trim();
                //Console.WriteLine("{0}", strTemp);
                strList.Add(strTemp);
            }
            strList.Sort();
            int index = 1;
            int sumTotal = 0;

            foreach(string eleStr in strList)
            {
                int point = 0;
                foreach (char eleChar in eleStr)
                {
                    switch (eleChar)
                    {
                        case 'A':
                            point = point + 1;
                            break;

                        case 'B':
                            point = point + 2;
                            break;

                        case 'C':
                            point = point + 3;
                            break;

                        case 'D':
                            point = point + 4;
                            break;

                        case 'E':
                            point = point + 5;
                            break;

                        case 'F':
                            point = point + 6;
                            break;

                        case 'G':
                            point = point + 7;
                            break;

                        case 'H':
                            point = point + 8;
                            break;

                        case 'I':
                            point = point + 9;
                            break;

                        case 'J':
                            point = point + 10;
                            break;

                        case 'K':
                            point = point + 11;
                            break;

                        case 'L':
                            point = point + 12;
                            break;

                        case 'M':
                            point = point + 13;
                            break;

                        case 'N':
                            point = point + 14;
                            break;

                        case 'O':
                            point = point + 15;
                            break;

                        case 'P':
                            point = point + 16;
                            break;

                        case 'Q':
                            point = point + 17;
                            break;

                        case 'R':
                            point = point + 18;
                            break;

                        case 'S':
                            point = point + 19;
                            break;

                        case 'T':
                            point = point + 20;
                            break;

                        case 'U':
                            point = point + 21;
                            break;

                        case 'V':
                            point = point + 22;
                            break;

                        case 'W':
                            point = point + 23;
                            break;

                        case 'X':
                            point = point + 24;
                            break;

                        case 'Y':
                            point = point + 25;
                            break;

                        case 'Z':
                            point = point + 26;
                            break;

                        default:
                            break;
                    }
                }
                int indexPoint = index * point;
                sumTotal = sumTotal + indexPoint;
                Console.WriteLine("#{0}:{1} POINT:{2} I X P = {3}", index, eleStr, point, indexPoint);
                /*
                if(index == 940)
                {
                    break;
                }
                */
                index++;
            }
            Console.WriteLine("sum is {0}", sumTotal);
        }








    }
}
