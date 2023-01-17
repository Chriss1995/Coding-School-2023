using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Methods
{
    internal class MethodReverse: Method
    {
        public override string Run(string input, out string output )
        {
            char[] charArray = input.ToCharArray();
            string output = string.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                output += charArray[i];
            }
            return output;
        }
    }
}
