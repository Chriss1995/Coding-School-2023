using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResolver
    {
        //Properties
        public MessageLogger Logger { get; set; }

        //Constructors
        public ActionResolver()
        {Logger = new MessageLogger()

        }
        //Methods
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.ResponseID=Guid.NewGuid();
            response.RequestID = request.RequestID;
            Log("Execution Start");
            try
            {
                switch(request.Action) {
                }
            }

            return null;
        }
        private void Log(string text) {
            Message message = new Message(text);
            Logger.Write(message);
        }
    }
}
