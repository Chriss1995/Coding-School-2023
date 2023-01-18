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
        public string? Text { get; set; }
        // Constractor
        public Message() {
            ID = Guid.NewGuid();
        }
        public Message(string text)
        {
            ID= Guid.NewGuid();
            TimeStamp = DateTime.Now;
            Text =text;
        }

    }
}


