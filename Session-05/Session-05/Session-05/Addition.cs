using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Addition
    {
        static int Add(int num1)
        {
            int i, sum = 0;_= num1;
            for (i = 0; i <= num1; i++)
            { sum = sum + 1; }
            return sum;
        }
      
    }
}
