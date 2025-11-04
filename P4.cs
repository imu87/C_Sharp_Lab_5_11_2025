using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.CSharpLab_5_11_25
{
    internal class P4
    {
        public static void Main(string[] args)
        {
            int even = 0; int odd = 0;
            for( int i = 1; i<=100; i++)
            {
                if (i % 2 == 0)
                {
                    even = even + i;
                }
                else odd = odd + i;
            } Console.WriteLine($"Even ={even} and Odd ={odd}");
        }
    }
}
