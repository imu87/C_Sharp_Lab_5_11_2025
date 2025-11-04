using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.CSharpLab_5_11_25
{
    internal class P2
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i <4; i++ )
            {
                for(int j = 0; j< 6; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else Console.Write("O");

                    
                }
                Console.WriteLine();

            }
        }
    }
}
