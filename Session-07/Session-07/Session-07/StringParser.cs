using Session_07.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class MethodParser
    {
        public string? text {get; set;}
        public virtual string Dothat(string input)
        {
            return  input;
        }
    }
    public class MethodConversion : MethodParser
    {
        public override string Dothat(string input)
        {
            bool Convertedval = Decimal.TryParse(input);
            if (Convertedval)
            {
                int number = int.Parse(input);
                string output = string.Empty;
                for (int i = 0; number > 0; i++)
                {
                    output = number % 2 + output;
                    number = number / 2;
                }
                return output;
            }
            else { return string.Empty; }
        }
    }
    internal class MethodReverse : MethodParser
    {
        public override string Dothat(string input)
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
    internal class MethodUppercase : MethodParser
    {
        public override string Dothat(string input)
        {
            string output = input.ToUpper();
            return output;
        }

    }
}