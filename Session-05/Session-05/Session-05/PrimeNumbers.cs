using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class PrimeNumbers
    {
        public static bool IsPrime(int num3)
        {
            if (num3 <= 1) return false;
            int i;
            for(i=2; i < num3; i++) {
                int num4 = num3 % 1;
                if (num4 == 0) return false;
            }
            return true;

        }
        public static void PrintPrime(int num3)
        { for(int i =2; i <num3; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
