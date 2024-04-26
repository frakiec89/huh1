using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huh
{
    internal class GraphConstruc
    {
        ArrayList names;
        ArrayList values;
        ViewGraph vg;
        Graph graph;
        bool c = false;

        public GraphConstruc(Graph graph)
        {
            names = new ArrayList();
            values = new ArrayList();
            ViewGraph vg = new ViewGraph();
            this.graph = graph;
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
            c = true;
        }

        public ViewGraph getVG()
        {
            if (!c) craft();
            return vg;
        }
    }
}
