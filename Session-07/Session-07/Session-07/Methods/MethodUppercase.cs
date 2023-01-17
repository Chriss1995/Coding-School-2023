using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Methods
{
    internal class MethodUppercase: Method
    {public override bool Run(string input, out string putput)
        {
            string output = input.ToUpper();
            return output;
        }

    }
}
