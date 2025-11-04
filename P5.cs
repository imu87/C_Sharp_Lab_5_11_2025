using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.CSharpLab_5_11_25
{
    internal class P5
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i; j++) Console.Write(" ");



                Console.WriteLine(i);
            }
            
        }
    }
}
