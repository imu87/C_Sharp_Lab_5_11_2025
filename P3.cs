using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.CSharpLab_5_11_25
{
    internal class P3
    {
        public static void Main(string[] args)
        {
            for(int i = 1; i<=5; i++)
            {
                for(int j=i; j<i+5; j++)
                {
                    Console.Write(j);


                }
                Console.WriteLine();
            }
        }
    }
}
