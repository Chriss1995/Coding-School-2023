using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }
    public class ActionRequest
    {//Properties
        public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }
        // Constructors
        public ActionRequest()
        {
        }

    }
    public class ForActions
    {
        public string Reversion(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string reversedString = string.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            return reversedString;
        }
        public string Conversion(string Input)
        {
            bool Convertedval = Decimal.TryParse(out Input);
            if (Convertedval)
            {
                int number = int.Parse(Input);
                string result = string.Empty();
                for (int i = 0; number > 0; i++)
                {
                    result = number % 2 + result;
                    number = number / 2;
                }
            }

        }
        public string Uppercase(string Input)
        {
            string Outstring = Input.ToUpper();
        }
    }
    public string Action(string request)
    {
        string Output;
        switch (ActionEnum)
        {
            case ActionEnum.Convert:
                Output = ForActions.Conversion(request);
                break;
            case ActionEnum.Uppercase:
                Output = ForActions.Uppercase(request);
                break;
            case ActionEnum.Reverse:
                Output = ForActions.Reversion(request);
                break;
            default:
                Console.WriteLine("Error Message");
                break;
        }
    }
}
