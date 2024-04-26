using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huh
{
    public class GraphField
    {
        public string graphName { get; set; }
        public int graphValue { get; set; }
     
        public GraphField(string graphName, int graphValue)
        {
            this.graphName = graphName;
            this.graphValue = graphValue;
        }
    }
}
