using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace huh
{
    public class XamlFieldsCreater : MainWindow
    {

        public void XFCreater()
        {
            GraphFieid graphField = new GraphFieid();

            if (graphField.fieldQuantity == 2)
            {
                StackPanel stackPanel = new StackPanel()
                {
                    Orientation = Orientation.Horizontal,
                    Name = "spForTwoFields"
                };
                spValue.Children.Add(stackPanel);
                Label label = new Label()
                {
                    Content = "Enter name of graph:",
                    
                };
                stackPanel.Children.Add(label);
                TextBox textBox = new TextBox()
                { 
                    Name = "tbGraphName1"
                };
                stackPanel.Children.Add(textBox);
                

            }
            else
            { }
        }

        

    }
}
