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
    
}
