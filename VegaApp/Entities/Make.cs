using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegaApp.Entities
{
    public class Make
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual IEnumerable<Model> models { get; set; }
    }
}
