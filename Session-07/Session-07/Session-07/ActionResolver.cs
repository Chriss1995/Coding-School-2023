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
    public class ActionResolver
    {
        //Properties
        public MessageLogger Logger { get; set; }

        //Constructors
        public ActionResolver()
        {
            Logger = new MessageLogger();

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
                switch (request.Action) {
                    case ActionEnum.Convert:
                        Log("Convert");
                        response.Output = Convert(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                        response.Output= Uppercase(request.Input);
                        break;
                    case ActionEnum.Reverse:
                        Log("REVERSION");
                        response.Output= Reverse(request.Input);
                        break;
                    default:
                        Log("Error Message");
                        break;
                }
            }catch (Exception ex)
            {
                Log(ex.Message);
            }
            finally
            {
                Log("Execution Emd");
            }

            return response;
        }
        private void Log(string text) {
            Message message = new Message(text);
            Logger.Write(message);
        }
        public string Convert(string input)
        {
           MethodConversion convert = new MethodConversion();
            convert.text = input;
            return convert.Dothat(input);
        }
        public string Uppercase(string iput)
        {
            MethodUppercase uppercase = new MethodUppercase();
            uppercase.text = iput;
            return uppercase.Dothat(iput);
        }
        public string Reverse(string input)
        {
            MethodReverse reversion = new MethodReverse();
            reversion.text = input;
            return reversion.Dothat(input);
        }
    }

}
