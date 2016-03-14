using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            for(int i = 0;i < 1000; i++)
            {
                for(int j = 0;j<1000;j++)
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
    }
}
