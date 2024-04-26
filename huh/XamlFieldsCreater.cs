using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace huh
{
    public class XamlFieldsCreater : MainWindow
    {

        public void XFCreater()
        {
            Graph graphField = new Graph();
            MainWindow main = new MainWindow();
           

            if (String.IsNullOrEmpty(main.integ))
            {
                MessageBox.Show(main.integ, "MESSAGE", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else 
            {
                
                graphField.fieldQuantity = int.Parse(main.integ);
                for (int i = 1; i < graphField.fieldQuantity; i++)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal,
                        Name = "spForTwoFields" + i,

                    };
                    spValue.Children.Add(stackPanel);
                    Label label = new Label()
                    {
                        Content = "Enter name of graph:",

                    };
                    stackPanel.Children.Add(label);
                    TextBox textBox = new TextBox()
                    {
                        Name = "tbGraphName1" + i,
                    };
                    stackPanel.Children.Add(textBox);
                    Label label2 = new Label()
                    {
                        Content = "Enter value of graph:",

                    };
                    stackPanel.Children.Add(label2);
                    TextBox textBox2 = new TextBox()
                    {
                        Name = "tbGraphName" + i,
                    };
                    stackPanel.Children.Add(textBox2);
                }
            }    
        }
    }
}
