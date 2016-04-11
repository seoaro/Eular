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

                case 28:
                    Problem28();
                    break;

                case 30:
                    Problem30();
                    break;

                case 31:
                    Problem31();
                    break;

                case 34:
                    Problem34();
                    break;

                case 96:
                    Problem96();
                    break;

                default:
                    Console.WriteLine("There is no #{0} problem.", arg);
                    break;
                
            }
        
        }

        // Problem1
        // 1000보다 작은 자연수 중에서 3 또는 5의 배수를 모두 더하면?
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
        // 피보나치 수열에서 4백만 이하이면서 짝수인 항의 합
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
        // 가장 큰 소인수 구하기
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

        // Problem4
        // 세자리 수를 곱해 만들 수 있는 가장 큰 대칭수
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

        // Problem5
        // 1 ~ 20 사이의 어떤 수로도 나누어 떨어지는 가장 작은 수
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
        // 1부터 100까지 "제곱의 합"과 "합의 제곱"의 차는?
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
        // 10001번째의 소수
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
        // 1000자리 숫자 안에서 이어지는 5자리 숫자의 곱 중 최대값은?
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
        // a + b + c = 1000 이 되는 피타고라스 수
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
        // 이백만 이하 소수의 합
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
        // 20×20 격자에서 연속된 네 숫자의 곱 중 최대값
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
        // 500개 이상의 약수를 갖는 가장 작은 삼각수는?
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
        // 50자리 숫자 100개를 더한 값의 첫 10자리 구하기
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
        // 백만 이하로 시작하는 우박수 중 가장 긴 과정을 거치는 것은?
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
        // 21000의 각 자리수를 모두 더하면?
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
        // 삼각형을 따라 내려가면서 합이 최대가 되는 경로 찾기
        static void Problem18()
        {
            ReadFromFile triangle1 = new ReadFromFile("triangle1");
            List<int> sumList = new List<int>();
            TriOrder triOrder = new TriOrder();
            List<TriOrder> triList = new List<TriOrder>();
            string[] strArray = triangle1.LineString;
            int j = 0;
            int line = 0;
            int sum = 0;
            foreach(string element in strArray)
            {
                int i = 0;
                int index = 0;
                List<int> intList = new List<int>();
                
                while(i < j + 1)
                {
                    string numStr = "";
                    numStr = numStr + element[i].ToString() + element[i + 1].ToString();
                    int intTemp;
                    Int32.TryParse(numStr, out intTemp);
                    triOrder.line = line;
                    triOrder.index = index;
                    triOrder.value = intTemp;

                    for (int o = 0; o < 100; o++)
                    {

                    }
                    intList.Add(intTemp);
                    
                    triList.Add(triOrder);
                    i = i + 3;
                    index++;
                }
                List<int> tempList = new List<int>();
                tempList = intList;

                int compare = 0;
                foreach(int eleInt in intList)
                {
                    if(eleInt > compare)
                    {
                        compare = eleInt;
                    }
                }


                Console.WriteLine("#{0}: {1}", j, compare);
                sum = sum + compare;
                
                j = j + 3;
                line++;
                
            }
            //Console.WriteLine("The sum of max numbers of each line is {0}", sum);
            
            int triCount = 0;
            int triTemp = 0;
            int triSum = 0;
            foreach(TriOrder eleTri in triList)
            {
                Console.WriteLine("({0},{1}): {2}", eleTri.line, eleTri.index, eleTri.value);
                if(eleTri.line == triCount)
                {

                    triTemp = eleTri.value;
                    triCount++;
                }
            }
            
        }

        // Problem20
        // 100! 의 자리수를 모두 더하면?
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
        // 10000 이하 모든 친화수(우애수)의 합은?
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
        // 영문 이름 점수 합계 구하기
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

        // Problem28
        // 1001×1001 나선모양 행렬에서 대각선 원소의 합은?
        static void Problem28()
        {
            int num = 1;
            int plus = 2;
            int sum = 1;
            for(int i = 0; i < 500; i++)
            {
                for(int j = 0;j < 4; j++)
                {
                    num = num + plus;
                    Console.WriteLine("#{0}: {1}", j, num);
                    sum = sum + num;
                }
                plus = plus + 2;
                
            }
            Console.WriteLine("sum is {0}", sum);
            
        }

        // Problem30
        // 각 자리 숫자를 5제곱해서 더했을 때 자기 자신이 되는 수들의 합은?
        static void Problem30()
        {
            int test = (int)Math.Pow(9, 5) * 4;
            //Console.WriteLine("{0}", test);
            int sum = 0;
            for (int i = 2; i < 236197; i++)
            {
                string intStr = i.ToString();
                int sumTemp = 0;
                foreach(char element in intStr)
                {
                    string strTemp = element.ToString();
                    int intTemp;
                    Int32.TryParse(strTemp, out intTemp);
                    
                    sumTemp = sumTemp + (int)Math.Pow(intTemp, 5);

                }
                if(i == sumTemp)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}", i);
                }
                
            }
            Console.WriteLine("sum is {0}", sum);
        }

        // Problem31
        // 영국 화폐 액면가를 조합하는 방법의 수
        static void Problem31()
        {

            int pense200, pense100, pense50, pense20, pense10, pense5, pense2, pense1;
            int count = 0;
            for (int p200 = 0; p200 <= 1; p200++)
            {
                pense200 = p200 * 200;
                for (int p100 = 0; p100 <= 2; p100++)
                {
                    pense100 = p100 * 100;
                    for (int p50 = 0; p50 <= 4; p50++)
                    {
                        pense50 = p50 * 50;
                        for (int p20 = 0; p20 <= 10; p20++)
                        {
                            pense20 = p20 * 20;
                            for (int p10 = 0; p10 <= 20; p10++)
                            {
                                pense10 = p10 * 10;
                                for (int p5 = 0; p5 <= 40; p5++)
                                {
                                    pense5 = p5 * 5;
                                    for (int p2 = 0; p2 <= 100; p2++)
                                    {
                                        pense2 = p2 * 2;
                                        for (int p1 = 0; p1 <= 200; p1++)
                                        {
                                            pense1 = p1 * 1;
                                            if (pense200 + pense100 + pense50 + pense20 + pense10 + pense5 + pense2 + pense1 == 200)
                                            {
                                                Console.WriteLine("{0}X£2 + {1}X£1 + {2}Xp50 + {3}Xp20 + {4}Xp10 + {5}Xp5 + {6}Xp2 + {7}Xp1 = 200", p200, p100, p50, p20, p10, p5, p2, p1);
                                                count++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
        }
            Console.WriteLine("count is {0}", count);
            
        }

        // Problem34
        // 각 자릿수의 팩토리얼을 더했을 때 자기 자신이 되는 수들의 합은?
        static void Problem34()
        {
            int[] Factorials = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            int result = 0;
            for(int i = 3; i < 1000000; i++)
            {
                string strTemp = i.ToString();
                string strEle = "";
                int sumFac = 0;
                foreach(char element in strTemp)
                {
                    strEle = strEle + element.ToString();
                    
                    int intTemp;
                    Int32.TryParse(element.ToString(), out intTemp);
                    /*
                    int factorial = 1;
                    for(int j = intTemp; j > 0; j--)
                    {
                        factorial = factorial * j;
                    }
                    sumFac = sumFac + factorial;
                    */
                    sumFac = sumFac + Factorials[intTemp];
                }
                
                if(i == sumFac)
                {
                    Console.WriteLine("#{0}", i);
                    result = result + i;
                }
                
            }
            Console.WriteLine("result : {0}", result);
        }

        // Problem96
        // 스도쿠 퍼즐 풀기
        static void Problem96()
        {
            ReadFromFile SudokuGrid = new ReadFromFile("sudoku");
            string[] sudoku = SudokuGrid.LineString;
            int[] intArray = new int[9];
            List<int[]> sudokuInt = new List<int[]>();

            for (int i = 0; i < 491; i = i + 10)
            {
                for (int j = 0; j < 9; j++)
                {
                    string strTemp;
                    strTemp = sudoku[i + j + 1];

                    //int[] intArray = new int[9];
                    int index = 0;
                    foreach(char eleChar in strTemp)
                    {
                        string charToStr = eleChar.ToString();
                        int intTemp;
                        Int32.TryParse(charToStr, out intTemp);
                        intArray[index] = intTemp;
                        index++;
                        
                    }
                    foreach(int eleInt in intArray)
                    {
                        Console.Write("{0}", eleInt);
                    }
                    Console.WriteLine("");
                    sudokuInt.Add(intArray);
                    
                    
                }
                Console.WriteLine("");

            }
            foreach(int[] ele in sudokuInt)
            {
                //Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", ele[0], ele[1], ele[2], ele[3], ele[4], ele[5], ele[6], ele[7], ele[8]);
            }
        }














        public struct TriOrder
        {
            public int line;
            public int index;
            public int value;

            public TriOrder(int i, int j, int k)
            {
                line = i;
                index = j;
                value = k;
            }
        }


    }
}
