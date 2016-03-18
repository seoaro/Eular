using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Int64 num = 1;
            int compare = 0;
            while(true)
            {
                while(i < 10)
                {
                    if(num % (i + 1) == 0)
                    {
                        compare++;
                    }
                    i++;
                }
                if(compare == 10)
                {
                    Console.WriteLine("The Number is : {0}", num);
                    break;
                }
                num++;
                i = 0;
                compare = 0;
                

            }
        }
    }
}
