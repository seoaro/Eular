using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Selector Problem = new Selector();
            string s = null;
            do
            {
                Console.WriteLine("Please, Input a problem number then press enter key.");
                s = Console.ReadLine();
            }
            while (s == null);
            
            int numTemp;
            if(Int32.TryParse(s, out numTemp))
            {
                Console.WriteLine("#{0} Problem is selected.", numTemp);
                Selector SN = new Selector(Number = numTemp);
                //SN.Number = numTemp;
                
                
            }
            else
            {
                Console.WriteLine("Please, Input a problem number then press enter key.");
            }
            
            
        }



        public static int Number { get; set; }
    }

}
