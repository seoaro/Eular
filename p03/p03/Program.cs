using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Int64 j = 600851475143;
            
            while(true){
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
    }
}
