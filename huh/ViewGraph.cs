using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace huh
{
   public class ViewGraph
   {
        public List<GraphField> graphs { get; set; }
        public List<GraphField> graph { get; set; }

        public ViewGraph() {
            graphs = new List<GraphField>();
            graph = new List<GraphField>()
            {
                new GraphField("Makaka", 21),
                new GraphField("asd", 1)
            };
        }



       
        public void addGraphField(String str, int integ)
        {
          //  MessageBox.Show(str + " " + integ, "MESSAGE", MessageBoxButton.OK, MessageBoxImage.Information);
            graphs.Add(new GraphField()
            {
                graphName = str,
                graphValue = integ
            });
        }
   }
}
