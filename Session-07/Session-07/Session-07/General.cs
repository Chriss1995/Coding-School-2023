using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public enum ActionEnum{
    Convert,
    Uppercase,
    Reverse}
    
    public class Message
    {

    }
    public class MessageLogger
    {

    }
    public class ActionRequest
    {

    }
    public class ActionResponse
    {

    }
    public class ActionResolver
    {
        //Properties
        public MessageLogger Logger { get; set; }

        //Constructors
        public ActionResolver()
        {

        }
        //Methods
        public ActionResponse Execute(ActionRequest request)
        {


            return null;
        }
    }
}
