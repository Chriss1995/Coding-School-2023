using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.Methods
{
    internal class Method
    {public string input { get;set;}
    public string output { get;set;}

    public Method() {  }

    public virtual bool Run(string input, out string output)
        {
            output = "No action given";
            return false;
        }
    }
}
