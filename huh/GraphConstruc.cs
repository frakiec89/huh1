using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace huh
{
    internal class GraphConstruc
    {
        ArrayList names;
        ArrayList values;
        public ViewGraph vg;
        Graph graph;

        public GraphConstruc(Graph graph)
        {
            names = new ArrayList();
            values = new ArrayList();
            this.graph = graph;
            vg = new ViewGraph();
        }

        public void addName(String name)
        {
            names.Add(name);
        }

        public void addValues(int integer)
        {
            values.Add(integer);
        }

        private void craft()
        {
            for (int i = 0; i < graph.fieldQuantity; i++)
            {
                vg.addGraphField((String)names[i], (int)values[i]);
            }
        }

        public void getVG()
        {
            craft();
        }
    }
}
