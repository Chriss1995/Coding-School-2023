using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Methods
{
    public class Method1
    {
        public virtual string Reversion(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string reversedString = string.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            return reversedString;
        }
    }
}
