using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Methods
{internal class MethodConversion:Method 
    {
        public override bool Run(string input, out string output)
        {
            bool Convertedval = Decimal.TryParse(input, out);
            if (Convertedval)
            {
                int number = int.Parse(input);
                string output = string.Empty;
                for (int i = 0; number > 0; i++)
                {
                    output = number % 2 + output;
                    number = number / 2;
                } return output;
            } else { return string.Empty; }
        }
    }
}
