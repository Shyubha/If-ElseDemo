

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_IfElse_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Please Enter Any NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Number is EVEN");
            }
            else
            {
                Console.WriteLine("Number is ODD");
            }
            Console.ReadLine();
            goto start;
        }
    }
}