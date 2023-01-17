using Session_07.Methods;
using System;
using System.Collections.Generic;
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
    public class Action
    {public void Method2(ActionEnum action)
        {
            switch (action)
            {
                case ActionEnum.Convert:
                    action = new MethodConversion();
                    break;
                case ActionEnum.Uppercase:
                    action = new MethodUppercase();
                    break;
                case ActionEnum.Reverse:
                    action = new MethodReverse();
                    break;
            default:
                    action = Console.WriteLine("Error Mssage");
            }
        }
    }
}
