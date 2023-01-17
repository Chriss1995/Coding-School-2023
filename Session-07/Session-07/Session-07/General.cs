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
    {//Properties
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string text_message { get; set; }
        // Constractor
        public Message() { }
    }
    public class MessageLogger
    {// Properties
        public Message[] Messages { get; set; }
        //Contstructor
        public MessageLogger()
        { }
        // Methods
        public void ReadAll()
        {

        }
        public void Clear()
        {

        }
        public Message Write()
        {

        }

    }
    public class ActionRequest
    {//Properties
       public Guid RequestID { get; set; }
        public string Input { get; set; }
        public ActionEnum Action { get; set; }
    // Constructors
     public ActionRequest() {
        }

   }
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
