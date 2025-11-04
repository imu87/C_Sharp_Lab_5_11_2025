using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.CSharpLab_5_11_25
{
    internal class P8
    {
        static void Main()
        {
            double phy, che, bio, math, com;
            Console.Write("Physics: ");
            phy = double.Parse(Console.ReadLine());

            Console.Write("Chemistry: ");
            che = double.Parse(Console.ReadLine());

            Console.Write("Biology: ");
            bio = double.Parse(Console.ReadLine());

            Console.Write("Math: ");
            math = double.Parse(Console.ReadLine());

            Console.Write("Computer: ");
            com = double.Parse(Console.ReadLine());



            double percent = (phy + che + bio + math + com) / 5;

            if (percent >= 90)
            {
                Console.WriteLine($"Percentage : {percent}% Garde : A+");
            }
            else if (percent >= 85)
            {
                Console.WriteLine($"Percentage : {percent}% Garde : A");
            }

            else if (percent >= 80)
            {
                Console.WriteLine($"Percentage : {percent}% Garde : B+");
            }

            else if (percent >= 75)
            {
                Console.WriteLine($"Percentage : {percent}% Garde : B");
            }

            else  
            {
                Console.WriteLine($"Percentage : {percent}% Garde : C+");
            }


        }
    }
}
