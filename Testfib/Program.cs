using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testfib
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 2;
            var number2 = 2;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(number1);
                var num = number1;
                number1 = number2;
                number2 += num;
            }
        }
    }
}
