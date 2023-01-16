using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Institute
    { public Guid ID { get; set; }
    public string? Name { get; set; }
    public int YearsInService { get; set; }
        public Institute() { }
        public void GetName() { }
        public void SetName(string name) { }
    }
}
