using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Methods
{internal class Method2
    {
        public virtual string Conversion(string Input)
        {
            bool Convertedval = Decimal.TryParse(Input, out);
            if (Convertedval)
            {
                int number = int.Parse(Input);
                string result = string.Empty;
                for (int i = 0; number > 0; i++)
                {
                    result = number % 2 + result;
                    number = number / 2;
                } return result;
            } else { return string.Empty; }
        }
    }
}
