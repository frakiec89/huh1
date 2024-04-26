using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace huh
{
   public class ViewGraph
   {
        public List<GraphField> graphs { get; set; }

        public void addGraphField(String str, int integ)
        {
            graphs.Add(new GraphField(str, integ));
        }
   }
}
