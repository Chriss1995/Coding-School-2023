using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResponse
    {//Properties
        public Guid ResponseID { get; set; }
        public Guid RequestID { get; set; }
        public String Output { get; set; }

        //Constructors
        public ActionResponse()
        {

        }
    }
}