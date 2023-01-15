using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Factorial

    {
        public static int Fact(int num2)
        {
            int i,_= num2, fact;
            fact = num2;
            for (i = num2 - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
