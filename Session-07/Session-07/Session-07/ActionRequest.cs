using Microsoft.VisualBasic;
using Session_07.Methods;
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
   
        

    public class EnumAction
    {
        public string Action(string request)
        {
            string Output;
            switch (ActionEnum)
            {
                case ActionEnum.Convert:
                    Method2 method2 = new Method2();
                    Output = Method2.Conversion(request);
                    break;
                case ActionEnum.Uppercase:
                    Method3 method3 = new Method3();
                    Output = ForActions.Uppercase(request);
                    break;
                case ActionEnum.Reverse:
                    Method1 method1 = new Method1();
                    Output = Method1.Reversion(request);
                    break;
                default:
                    Console.WriteLine("Error Message");
                    break;
            }
        }
    }
}
