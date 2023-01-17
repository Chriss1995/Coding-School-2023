using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class Message
    {//Properties
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string text_message { get; set; }
        // Constractor
        public Message() { }
    }
}


